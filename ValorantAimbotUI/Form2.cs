using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iBaseult
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            intro1.Visible = false;
            skip1.Visible = false;
            start1.Visible = false;
            Introb.Visible = true;
            Introt.Visible = true;
        }

        private void tutt2_Click(object sender, EventArgs e)
        {

        }

        private void tutb2_Click(object sender, EventArgs e)
        {
            tutt2.Visible = false;
            tutb2.Visible = false;
            tutt3.Visible = true;
            tutb3.Visible = true;
            tut3.Visible = true;
        }

        private void Introb_Click(object sender, EventArgs e)
        {
            Introt.Visible = false;
            Introb.Visible = false;
            tutt1.Visible = true;
            tutb1.Visible = true;
            tutx1.Visible = true;
            tut1.Visible = true;
        }

        private void tutb1_Click(object sender, EventArgs e)
        {
            tutt1.Visible = false;
            tutb1.Visible = false;
            tut2.Visible = true;
            tutb2.Visible = true;
            tutt2.Visible = true;
        }

        private void tutb3_Click(object sender, EventArgs e)
        {
            tutt3.Visible = false;
            tutb3.Visible = false;
            tutt4.Visible = true;
            tutb4.Visible = true;
            tut4.Visible = true;
        }

        private void tutb4_Click(object sender, EventArgs e)
        {
            tutt4.Visible = false;
            tutb4.Visible = false;
            tutt5.Visible = true;
            tutb5.Visible = true;
            tut5.Visible = true;
        }

        private void tutb5_Click(object sender, EventArgs e)
        {
            tutx1.Visible = false;
            tut1.Visible = false;
            tut2.Visible = false;
            tut3.Visible = false;
            tut4.Visible = false;
            tut5.Visible = false;
            tutt5.Visible = false;
            tutb5.Visible = false;

            tutt6.Visible = true;
            tutb6.Visible = true;
            tut6.Visible = true;
            tutx2.Visible = true;
        }

        private void tutb6_Click(object sender, EventArgs e)
        {
            tutt6.Visible = false;
            tutb6.Visible = false;

            tutt7.Visible = true;
            tutb7.Visible = true;
            tut7.Visible = true;
        }

        private void tutb7_Click(object sender, EventArgs e)
        {
            tutt7.Visible = false;
            tutb7.Visible = false;
            tut7.Visible = false;
            tut6.Visible = false;

            tutx3.Visible = true;
            tut8a.Visible = true;
            tut8b.Visible = true;
            tut8c.Visible = true;
            tut8d.Visible = true;
            tut8e.Visible = true;
            tut8f.Visible = true;
            tut8g.Visible = true;
            tut8h.Visible = true;
            tut8i.Visible = true;
            tutt8.Visible = true;
            tutb8.Visible = true;
        }

        private void tutb8_Click(object sender, EventArgs e)
        {
            tut8a.Visible = false;
            tut8b.Visible = false;
            tut8c.Visible = false;
            tut8d.Visible = false;
            tut8e.Visible = false;
            tut8f.Visible = false;
            tut8g.Visible = false;
            tut8h.Visible = false;
            tut8i.Visible = false;
            tutt8.Visible = false;
            tutb8.Visible = false;
            tutx3.Visible = false;
            tutx2.Visible = false;

            tut9.Visible = true;
            tutb9.Visible = true;
            tutt9.Visible = true;
        }

        private void tutb9_Click(object sender, EventArgs e)
        {
            tutb9.Visible = false;
            tutt9.Visible = false;

            tutt10.Visible = true;
            tutb10.Visible = true;
            tut10a.Visible = true;
            tut10b.Visible = true;
        }

        private void tutb10_Click(object sender, EventArgs e)
        {
            tutt10.Visible = false;
            tutb10.Visible = false;

            tutt11.Visible = true;
            tutb11.Visible = true;
            tut11a.Visible = true;
            tut11b.Visible = true;
            tut11c.Visible = true;
            tut11d.Visible = true;
        }

        private void tutb11_Click(object sender, EventArgs e)
        {
            tutt11.Visible = false;
            tutb11.Visible = false;

            tutt12.Visible = true;
            tutb12.Visible = true;
            tut12a.Visible = true;
            tut12b.Visible = true;
        }

        private void tutb12_Click(object sender, EventArgs e)
        {
            tutt12.Visible = false;
            tutb12.Visible = false;
            tut12a.Visible = false;
            tut12b.Visible = false;
            tut11a.Visible = false;
            tut11b.Visible = false;
            tut11c.Visible = false;
            tut11d.Visible = false;
            tut10a.Visible = false;
            tut10b.Visible = false;
            tut9.Visible = false;

            tut13.Visible = true;
            tutb13.Visible = true;
            tutt13.Visible = true;
        }

        private void tutb13_Click(object sender, EventArgs e)
        {
            tutb13.Visible = false;
            tutt13.Visible = false;

            tutb14.Visible = true;
            tutt14.Visible = true;
            tut14a.Visible = true;
        }

        private void tutb14_Click(object sender, EventArgs e)
        {
            tutb14.Visible = false;
            tutt14.Visible = false;

            tutb15.Visible = true;
            tutt15.Visible = true;
            tut15b.Visible = true;
            tut15c.Visible = true;
            tut16a.Visible = true;
            tut16b.Visible = true;
        }

        private void tutb15_Click(object sender, EventArgs e)
        {
            tutb15.Visible = false;
            tutt15.Visible = false;
            tut17a.Visible = true;
            tut17b.Visible = true;
            tutt17.Visible = true;
            tutb17.Visible = true;
        }

        private void tutb17_Click(object sender, EventArgs e)
        {
            tut17a.Visible = false;
            tut17b.Visible = false;
            tutt17.Visible = false;
            tutb17.Visible = false;
            tut15b.Visible = false;
            tut15c.Visible = false;
            tut16a.Visible = false;
            tut16b.Visible = false;
            tut14a.Visible = false;
            tut13.Visible = false;

            tutt18.Visible = true;
            tutb18.Visible = true;
            tut18a.Visible = true;
            tut18b.Visible = true;
            tut18c.Visible = true;
            tut18d.Visible = true;
            tut18e.Visible = true;
            tut18f.Visible = true;
            tut18g.Visible = true;
            tut18h.Visible = true;
            tut18i.Visible = true;
            tut18j.Visible = true;
            tut18k.Visible = true;
        }

        private void tutb18_Click(object sender, EventArgs e)
        {
            tutt18.Visible = false;
            tutb18.Visible = false;

            tut19a.Visible = true;
            tut19b.Visible = true;
            tutt19.Visible = true;
            tutb19.Visible = true;
        }

        private void tutb19_Click(object sender, EventArgs e)
        {

            tut18a.Visible = false;
            tut18b.Visible = false;
            tut18c.Visible = false;
            tut18d.Visible = false;
            tut18e.Visible = false;
            tut18f.Visible = false;
            tut18g.Visible = false;
            tut18h.Visible = false;
            tut18i.Visible = false;
            tut18j.Visible = false;
            tut18k.Visible = false;
            tut19a.Visible = false;
            tut19b.Visible = false;
            tutb19.Visible = false;
            tutt19.Visible = false;


            tut20a.Visible = true;
            tut20b.Visible = true;
            tut20c.Visible = true;
            tut20d.Visible = true;
            tut20e.Visible = true;
            tutt20.Visible = true;
            tutb20.Visible = true;
        }

        private void tutb20_Click(object sender, EventArgs e)
        {
            tut20a.Visible = false;
            tut20b.Visible = false;
            tut20c.Visible = false;
            tut20d.Visible = false;
            tut20e.Visible = false;
            tutt20.Visible = false;
            tutb20.Visible = false;

            tut21a.Visible = true;
            tut21b.Visible = true;
            tutt21.Visible = true;
            tutb21.Visible = true;
        }

        private void tutb21_Click(object sender, EventArgs e)
        {
            tut21a.Visible = false;
            tut21b.Visible = false;
            tutt21.Visible = false;
            tutb21.Visible = false;

            finish.Visible = true;
        }

        private void finish_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
