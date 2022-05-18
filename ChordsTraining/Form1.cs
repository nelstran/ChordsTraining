using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChordsTraining
{
    public partial class Form1 : Form
    {
        Graphics g;
        Chord currChord = new Chord();
        Button disabled;
        Button temp;
        int currRoot = 0;
        bool reveal = false;
        bool panelOpen = true;

        /// <summary>
        /// Class <c>Chord</c> Representation of a Piano Chord
        /// </summary>
        public struct Chord
        {
            public int root;
            public int quality;
            public int extend;
            private static Point[] points;
            private static Point cRoot = new Point(17, 170);
            private static int radius = 7;
            private static int[,] qualities = new int[5, 4] {
                {0, 3, 4, 3 },//Minor
                {0, 4, 3, 4 },//Major
                {0, 3, 3, 3 },//Diminished
                {0, 4, 4, 2 },//Augmented
                {0, 4, 3, 3 } //7th
            };

            /// <summary>
            /// Initialize a chord.
            /// Root 0-11 (0 = C, 1 = C#, etc.)
            /// Quality 0-5 (0 = Minor, 1 = Major, 2 = Dim, 3 = Aug, 4 = 7th)
            /// Extend 0-1 0 = Triad, 1 = 7th
            /// </summary>
            /// <param name="root"></param>
            /// <param name="quality"></param>
            /// <param name="extend"></param>
            public Chord(int root, int quality, int extend)
            {
                if (root > 11 || extend > 1 || quality > 5)
                    throw new Exception("Invalid chord structure");
                if(extend == 0 && quality == 4)
                    throw new Exception("Triad cannot be a 7th Chord");

                this.root = root;
                this.quality = quality;
                this.extend = extend;
            }

            /// <summary>
            /// Generate a random chord
            /// </summary>
            public void generateChord()
            {
                Random rng = new Random();

                //C to B (Easier to code)
                // 0 = C, 1 = C#, etc.
                root = rng.Next(12);

                //Triad, 7th
                extend = rng.Next(2);

                //Minor, Major, Dim, Aug, 7
                quality = rng.Next(extend == 1 ? 5 : 4);
                Console.WriteLine($"{root} {extend} {quality}");

                generateLocation();
            }

            /// <summary>
            /// Private method to generate the locations of the chord
            /// </summary>
            public void generateLocation()
            {
                points = new Point[3 + extend];

                //Start at root of the chord
                int index = root;
                for(int i = 0; i < points.Length; i++)
                {
                    //Go up a certain number of half steps depending on the chord
                    index += qualities[quality, i];

                    int x = 17*(index+1);
                    int y = 0;

                    //Sets the points in the correct position
                    if(index % 12 >= 5)
                    {
                        x += 16;
                        y = (index+1) % 2 == 0 ? cRoot.Y : 95;
                    }
                    else
                    {
                        y = (index + 1) % 2 == 1 ? cRoot.Y : 95;
                    }

                    //If note reaches past an octave, move accordingly
                    x += index >= 12 ? 32 : 0;

                    points[i] = new Point(x, y);
                }
            }

            /// <summary>
            /// Draw the locations of the notes on the pictureBox
            /// </summary>
            /// <param name="g"></param>
            public void drawLocation(Graphics g)
            {
                foreach (Point point in points)
                {
                    g.FillEllipse(Brushes.Red, new Rectangle(point.X - radius, point.Y - radius, radius * 2, radius * 2));
                }
            }

            /// <summary>
            /// Retrieves the name of the chord with the given properties
            /// </summary>
            /// <returns>Name of the Chord</returns>
            public string getName()
            {
                string[] root = new string[12] { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B"};
                string[] quality = new string[6] { "m", "maj", "dim", "aug", "7", ""};
                string[] extend = new string[2] { "", "7" };
                return $"{root[this.root]}" +
                    $"{quality[this.extend == 1 && this.quality == 4 ? 5 : this.quality]}" +
                    $"{extend[this.extend]}";
            }
        }
        public Form1()
        {
            InitializeComponent();
            keysPanel.Width = 0; //228
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Generate a random chord when opened
            currChord.generateChord();
            chordLabel.Text = currChord.getName();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //Draw graphics when asked to reveal
            if (!reveal)
                return;
            g = e.Graphics;
            currChord.drawLocation(g);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            //Generates a new chord and refreshes graphics
            reveal = false;
            revealButton.Enabled = true;
            pictureBox1.Invalidate();
            currChord.generateChord();
            chordLabel.Text = currChord.getName();
        }

        private void revealButton_Click(object sender, EventArgs e)
        {
            //Reveals the location of the notes
            reveal = true;
            revealButton.Enabled = false;
            pictureBox1.Invalidate();

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            if (panelOpen && keysPanel.Width > 0)
            {
                keysPanel.Width -= 12;
                return;
            }
            else if (!panelOpen && keysPanel.Width < 228)
            {
                keysPanel.Width += 12;
                return;
            }
            animationTimer.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool v = !panelOpen;
            panelOpen = v;
            animationTimer.Enabled = true;
            
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            button1_Click(sender,e);
        }

        private void letterMode(int root)
        {
            nextButton.Visible = false;
            revealButton.Visible = false;
            Chord chor;

            chor = new Chord(root, 1, 1);
            majButton.Text = chor.getName();
            majButton.Visible = true;
            disabled = majButton;

            chor.quality = 0;
            minButton.Text = chor.getName();
            minButton.Visible = true;

            chor.quality = 3;
            augButton.Text = chor.getName();
            augButton.Visible = true;

            chor.quality = 2;
            dimButton.Text = chor.getName();
            dimButton.Visible = true;

            chor.quality = 4;
            chor.extend = 0;
            sevButton.Text = chor.getName();
            sevButton.Visible = true;

            currRoot = root;
            changeChord(root, 1);
        }

        private void changeChord(int root, int quality)
        {
            if(temp != null)
                temp.Enabled = true;
            temp = disabled;
            temp.Enabled = false;
            pictureBox1.Invalidate();
            currChord = new Chord(root, quality, 1);
            currChord.generateLocation();
            chordLabel.Text = currChord.getName();
            reveal = true;
        }
        private void Abutton_Click(object sender, EventArgs e)
        {
            letterMode(9);
        }

        private void ASharpButton_Click(object sender, EventArgs e)
        {
            letterMode(10);
        }

        private void Bbutton_Click(object sender, EventArgs e)
        {
            letterMode(11);
        }

        private void Cbutton_Click(object sender, EventArgs e)
        {
            letterMode(0);
        }

        private void CSharpButton_Click(object sender, EventArgs e)
        {
            letterMode(1);
        }

        private void Dbutton_Click(object sender, EventArgs e)
        {
            letterMode(2);
        }

        private void DSharpButton_Click(object sender, EventArgs e)
        {
            letterMode(3);
        }

        private void ESharpButton_Click(object sender, EventArgs e)
        {
            letterMode(4);
        }

        private void FButton_Click(object sender, EventArgs e)
        {
            letterMode(5);
        }

        private void FSharpButton_Click(object sender, EventArgs e)
        {
            letterMode(6);
        }

        private void GButton_Click(object sender, EventArgs e)
        {
            letterMode(7);
        }

        private void GSharpButton_Click(object sender, EventArgs e)
        {
            letterMode(8);
        }

        private void majButton_Click(object sender, EventArgs e)
        {
            disabled = majButton;
            changeChord(currRoot, 1);
        }

        private void minButton_Click(object sender, EventArgs e)
        {
            disabled = minButton;
            changeChord(currRoot, 0);
        }

        private void sevButton_Click(object sender, EventArgs e)
        {
            disabled = sevButton;
            changeChord(currRoot, 4);
        }

        private void augButton_Click(object sender, EventArgs e)
        {
            disabled = augButton;
            changeChord(currRoot, 3);

        }

        private void dimButton_Click(object sender, EventArgs e)
        {
            disabled = dimButton;
            changeChord(currRoot, 2);
        }

        private void quizButton_Click(object sender, EventArgs e)
        {
            majButton.Visible = false;
            minButton.Visible = false;
            augButton.Visible = false;
            dimButton.Visible = false;
            sevButton.Visible = false;

            reveal = false;

            pictureBox1.Invalidate();
            currChord.generateChord();
            chordLabel.Text = currChord.getName();

            nextButton.Visible = true;
            revealButton.Enabled = true;
            revealButton.Visible = true;
        }
    }
}
