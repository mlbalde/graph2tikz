using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GraphToTIKZ
{
    public partial class frmStyleRepo : Form
    {
        //private TikzGraph m_G;
        public TikzGraph G;

        public frmStyleRepo()
        {
            InitializeComponent();
        }

        public void FillStyleList()
        {
            lstRepoStyles.Items.Clear();

            foreach (DrawObjectStyleBool k in StyleRepo.styles)
            {
                ListViewItem lvi = lstRepoStyles.Items.Add(k.dos.name);
                //lvi.Checked = k.l;
                //lvi.SubItems.Add(k.dos.name);
                lvi.SubItems.Add(k.dos.type.ToString());
                if (k.l)
                    lvi.SubItems.Add("Yes");
                else lvi.SubItems.Add("");
            }
        }

        private void frmStyleRepo_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void lstRepoStyles_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
           // StyleRepo.findStyle(e.Item.SubItems[1].Text).l = e.Item.Checked;
        }

        private void lstRepoStyles_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            // Determine if label is changed by checking for null.
            if (e.Label == null)
                return;

            string cNew = e.Label, cOld = lstRepoStyles.Items[e.Item].Text;
            if (cNew == "")
            {
                MessageBox.Show("Invalid style name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.CancelEdit = true;
            }
            else if (StyleRepo.findStyle(cNew) != null)
            {
                MessageBox.Show(cNew + ": a style with that name already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.CancelEdit = true;
            }
            else
            {
                DrawObjectStyleBool dosb = StyleRepo.findStyle(cOld);
                dosb.dos.name = cNew;
            }

        }

        private void cmdRename_Click(object sender, EventArgs e)
        {
            actionRename();
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lstRepoStyles.SelectedItems)
            {
                StyleRepo.DeleteStyle(lvi.Text);
            }
            FillStyleList();
        }

        private void cmdDefault_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lstRepoStyles.SelectedItems)
            {
                DrawObjectStyleBool dosb = StyleRepo.findStyle(lvi.Text);
                dosb.l = !dosb.l;
                if (dosb.l)
                    lvi.SubItems[2].Text = "Yes";
                else lvi.SubItems[2].Text = "";
            }
        }

        private void cmdAddToGraph_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lstRepoStyles.SelectedItems)
            {
                DrawObjectStyleBool dosb = StyleRepo.findStyle(lvi.Text);
                if (G.styles.ContainsKey(dosb.dos.name))
                {
                    if (G.styles[dosb.dos.name].type != dosb.dos.type)
                    {
                        MessageBox.Show(dosb.dos.name + ": Cannot replace a style with one of different type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        continue;
                    }
                    if (MessageBox.Show("A style with the name \"" + dosb.dos.name + "\"already exists in the graph. Overwrite?",
                        "Style exists", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) != System.Windows.Forms.DialogResult.Yes)
                        continue;
                }

                G.styles[dosb.dos.name] = dosb.dos.copy();
                // reset style references
                foreach (DrawObject o in G.objlist.Values)
                    o.style = G.styles[o.style.name];
            }
        }

        private void lstRepoStyles_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                actionRename();
        }

        void actionRename()
        {
            if (lstRepoStyles.SelectedItems.Count > 0)
                lstRepoStyles.SelectedItems[0].BeginEdit();
        }
    }
}
