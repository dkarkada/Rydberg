﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QMStuff_v2
{
	enum direction { N, E, S, W };

	public partial class Form1 : Form {
		Canvas c;
		int step = 1;
		System.Timers.Timer clock;

		public Form1() {
			InitializeComponent();
			SetSizeAndControls();

			clock = new System.Timers.Timer(500);
			clock.AutoReset = true;
			clock.Elapsed += new System.Timers.ElapsedEventHandler(PlayStep);

			DoubleBuffered = true;
			c.RenderNext();
		}
		private void SetSizeAndControls() {
			Size = Screen.FromControl(this).WorkingArea.Size;

			splitPanel.SplitterDistance = ClientSize.Width - splitPanel.Panel2.Height - splitPanel.SplitterWidth;

			c = new Canvas(	new Size(splitPanel.Panel2.Width, splitPanel.Panel2.Height));
			c.Dock = DockStyle.Fill;
			splitPanel.Panel2.Controls.Add(c);

			splitPanel.Panel2.BackColor = c.gs.bgBrush.Color;
			splitPanel.Panel1.BackColor = Color.FromArgb(60, 60, 75);
			playSpeedLabel.ForeColor = xProbLabel.ForeColor = yProbLabel.ForeColor
				= zoomLabel.ForeColor = Color.White;

			Resize += FrameResizing;
			splitPanel.SplitterMoved += SplitPanelResized;
		}
		private void FrameResizing(object sender, EventArgs e) {
			if(WindowState!=FormWindowState.Minimized)
				splitPanel.SplitterDistance = Math.Max(0, ClientSize.Width - splitPanel.Panel2.Height - splitPanel.SplitterWidth);
			c.sz = new Size(splitPanel.Panel2.Width, splitPanel.Panel2.Height);
			c.ReRender();
		}
		private void SplitPanelResized(object sender, SplitterEventArgs e) {
			c.sz = new Size(splitPanel.Panel2.Width, splitPanel.Panel2.Height);
			c.ReRender();
		}
        private void PlayStep(object source, System.Timers.ElapsedEventArgs e)
        {
            BeginInvoke(new Action(c.RenderNext), null);
        }
        private void backButton_Click(object sender, EventArgs e)
        {
            
        }
        private void fwdButton_Click(object sender, EventArgs e) {
			c.RenderNext();
		}
        private void playButton_Click(object sender, EventArgs e)
        {
            if (!clock.Enabled)
            {
                clock.Start();
                playButton.Text = "Pause";
                speedBar.Visible = playSpeedLabel.Visible = true;
            }
            else {
                clock.Stop();
                playButton.Text = "Play";
                speedBar.Visible = playSpeedLabel.Visible = false;
            }
        }
		private void resetZoomButton_Click(object sender, EventArgs e) {
			zoomBar.Value = 75;
			c.gs.zoom = 1;
			c.lat.aSize = 10;
			zoomLabel.Text = Math.Round(c.gs.zoom, 3) + "x";
			c.ReRender();
		}
		private void zoomOutButton_Click(object sender, EventArgs e) {
			if(zoomBar.Value >= 5) zoomBar.Value -= 5;
			else zoomBar.Value = 0;
			c.gs.zoom = Math.Pow(2, (zoomBar.Value - 75) / 25.0);
			zoomLabel.Text = Math.Round(c.gs.zoom, 3) + "x";
			c.lat.aSize = (int)(10 * c.gs.zoom);
			c.ReRender();
		}
		private void zoomInButton_Click(object sender, EventArgs e) {
			if(zoomBar.Value <= 95) zoomBar.Value += 5;
			else zoomBar.Value = 100;
			c.gs.zoom = Math.Pow(2, (zoomBar.Value - 75) / 25.0);
			zoomLabel.Text = Math.Round(c.gs.zoom, 3) + "x";
			c.lat.aSize = (int)(10 * c.gs.zoom);
			c.ReRender();
		}
		private void xProbBar_Scroll(object sender, EventArgs e) {
            c.lat.Xprobability = (double)(xProbBar.Value) / 100;
			xProbValue.Value = xProbBar.Value;
		}
		private void yProbBar_Scroll(object sender, EventArgs e) {
			c.lat.Yprobability = (double)(yProbBar.Value) / 100;
			yProbValue.Value = yProbBar.Value;
		}
		private void speedBar_Scroll(object sender, EventArgs e){
            clock.Interval = 900 - (speedBar.Value * 8);
		}
		private void zoomBar_Scroll(object sender, EventArgs e) {
			c.gs.zoom = Math.Pow(2, (zoomBar.Value-75)/25.0);
			zoomLabel.Text = Math.Round(c.gs.zoom, 3) + "x";
			c.lat.aSize = (int)(10 * c.gs.zoom);
			c.ReRender();
		}
		private void restartButton_Click(object sender, EventArgs e)
        {
            step = 1;
            clock.Stop();
			playButton.Text = "Play";
			speedBar.Visible = playSpeedLabel.Visible = false;
			c.lat.Xprobability = (double)(xProbBar.Value) / 100;
			c.lat.Yprobability = (double)(yProbBar.Value) / 100;
            stepCounter.Value = 1;
            c.ReRender();
        }
		private void xProbValue_ValueChanged(object sender, EventArgs e) {
			xProbBar.Value = (int) xProbValue.Value;
			c.lat.Xprobability = (double)(xProbBar.Value) / 100;
		}
		private void yProbValue_ValueChanged(object sender, EventArgs e) {
			yProbBar.Value = (int)yProbValue.Value;
			c.lat.Yprobability = (double)(yProbBar.Value) / 100;
		}

		
	}
	public class Canvas : Panel {
		public Bitmap image { get; set; }
		public Lattice lat { get; set; }
		public Size sz { get; set; }
		public GraphicsSettings gs;
		public int ind { get; set; }

		public Canvas(Size s) {
			lat = new Lattice();
			image = new Bitmap((int)(Math.Sqrt(lat.mat.Length)), (int)(Math.Sqrt(lat.mat.Length)));
			gs = new GraphicsSettings();
			sz = s;
			ind = 0;
			AutoSize = true;
			DoubleBuffered = true;
		}
		protected override void OnPaint(PaintEventArgs e) {
			Graphics g = e.Graphics;
			Bitmap final = new Bitmap(sz.Width, sz.Height);
			g.DrawImage(image, 0, 0);
		}
		public void RenderNext() {
			Graphics g = Graphics.FromImage(image);
			g.SmoothingMode = SmoothingMode.AntiAlias;
			if(gs.axes) {
				int w = image.Width;
				int h = image.Height;
				g.DrawLine(gs.axisPen, w / 2, 0, w / 2, h);
				g.DrawLine(gs.axisPen, 0, h / 2, w, h / 2);
			}
			if(ind < lat.changes.Count) {
				LatticeChange lc = lat.changes[ind];
				SolidBrush br = gs.fgBrush;
				foreach(Atom a in lc.on) {
					g.FillRectangle(br,
						(float) (image.Width/2 + lat.aSize*(a.x - .5)),
						(float) (image.Height/2 - lat.aSize*(a.y + .5)),
						lat.aSize, lat.aSize);
				}
				ind++;
			}
			Invalidate();
		}
		public void ReRender() {
			Graphics g = Graphics.FromImage(image);
			g.Clear(Color.Transparent);
			g.SmoothingMode = SmoothingMode.AntiAlias;
			if(gs.axes) {
				int w = image.Width;
				int h = image.Height;
				g.DrawLine(gs.axisPen, w / 2, 0, w / 2, h);
				g.DrawLine(gs.axisPen, 0, h / 2, w, h / 2);
			}
			for(int i=0; i<ind; i++) {
				LatticeChange lc = lat.changes[i];
				SolidBrush br = gs.fgBrush;
				foreach(Atom a in lc.on) {
					g.FillRectangle(br,
						(float)(image.Width/2 + lat.aSize*(a.x - .5)),
						(float)(image.Height/2 - lat.aSize*(a.y - .5)),
						lat.aSize, lat.aSize);
				}
			}
			Invalidate();
		}
		public void Restart() {
			lat = new Lattice();
			lat.aSize = (int)(10 * gs.zoom);
			lat.changes = new List<LatticeChange>();
			foreach(Atom a in lat.mat) {
				if(a.x == 0 && a.y == 0) {
					LatticeChange lc = new LatticeChange();
					lc.AddOn(a);
					lat.changes.Add(lc);
					a.excited = true;
				}
			}
		}
	}
	public class Lattice {
		public Atom[,] mat { get; set; }
		public double Xprobability { get; set; }
		public double Yprobability { get; set; }
		public int aSize { get; set; }
		public int sz { get; set; }
		public List<LatticeChange> changes { get; set; }
		public Random rnd { get; set; }

		public Lattice(){
            Xprobability = Yprobability = 1;
            aSize = 10;
            sz = 200;
			mat = new Atom[sz, sz];
			changes = new List<LatticeChange>();
			rnd = new Random();

			for (int i = 0; i < sz; i++)
            {
                for (int j = 0; j < sz; j++)
                {
                    mat[j, i] = new Atom(i - sz / 2, j - sz / 2, 0);
					if(i-sz/2==0 && j-sz/2==0) {
						LatticeChange lc = new LatticeChange();
						lc.AddOn(mat[j, i]);
						changes.Add(lc);
						mat[j, i].excited = true;
					}
				}
            }

			GenerateChanges(0);
		}
		public void GenerateChanges(int i) {
			Boolean done = false;
			LatticeChange lc = new LatticeChange();
			for(int r = 1; r < sz - 1; r++) {
				for(int c = 1; c < sz - 1; c++) {
					Atom a = mat[r, c];
					if(!a.excited) {
						int numActiveNeighbors = 0;
						int dir = 0;
						if(mat[r + 1, c].excited) {
							numActiveNeighbors++;
							dir = (int)direction.S;
						}
						if(mat[r, c + 1].excited) {
							numActiveNeighbors++;
							dir = (int)direction.E;
						}
						if(mat[r - 1, c].excited) {
							numActiveNeighbors++;
							dir = (int)direction.N;
						}
						if(mat[r, c - 1].excited) {
							numActiveNeighbors++;
							dir = (int)direction.W;
						}
						if(numActiveNeighbors == 1) {
							if((dir == (int)direction.N || dir == (int)direction.S) && rnd.NextDouble() < Yprobability)
								lc.AddOn(a);
							if((dir == (int)direction.E || dir == (int)direction.W) && rnd.NextDouble() < Xprobability)
								lc.AddOn(a);
							if(r>sz-2 || r<2 || c>sz-2 || c<2)
								done=true;
						}
					}
				}
			}
			foreach(Atom a in lc.on)
				a.excited = true;
			changes.Add(lc);
			Console.WriteLine(i);
			if(!done || i<100) GenerateChanges(++i);
		}
    }
    public class Atom
    {
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }
        public Boolean excited { get; set; }

        public Atom(int x1, int y1, int z1)
        {
            x = x1;
            y = y1;
            z = z1;
            excited = false;
        }
    }
    public class LatticeChange
    {
        public List<Atom> on { get; set; }
        public List<Atom> off { get; set; }

        public LatticeChange()
        {
            on = new List<Atom>();
            off = new List<Atom>();
        }
        public void AddOn(Atom a)
        {
            on.Add(a);
        }
        public void AddOff(Atom a)
        {
            off.Add(a);
        }
    }
    public class GraphicsSettings
    {
        public SolidBrush bgBrush { get; set; }
        public SolidBrush fgBrush { get; set; }
        public Pen axisPen { get; set; }
        public Boolean axes { get; set; }
		public double zoom { get; set; }

        public GraphicsSettings()
        {
            bgBrush = new SolidBrush(Color.Black);
            fgBrush = new SolidBrush(Color.PaleTurquoise);
            axisPen = new Pen(Color.PaleTurquoise, 1);
            axes = true;
			zoom = 1;
        }
    }
}
