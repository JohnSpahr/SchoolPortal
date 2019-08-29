using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.IO;

namespace Mac_Middle_School_Portal
{
    public partial class Schedule : MaterialForm
    {
        public Schedule()
        {
            InitializeComponent();
            dateandtime.Value = DateTime.Now;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //hide controls
            addBtn.Hide();
            removeBtn.Hide();
            clearBtn.Hide();
            //add event
            tabControl1.SelectedTab = createNew;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            //Show controls
            addBtn.Show();
            removeBtn.Show();
            clearBtn.Show();
            tabControl1.SelectedTab = events;
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            //create event
            if (descriptionBox.Text != "")
            {
                //Show controls
                addBtn.Show();
                removeBtn.Show();
                clearBtn.Show();
                //adds event
                eventsBox.Items.Add(dateandtime.Value + " - " + descriptionBox.Text);
                //resets everything
                tabControl1.SelectedTab = events;
                dateandtime.Value = DateTime.Now;
                descriptionBox.Text = "";
            }
            else
            {
                MessageBox.Show("Please add a description.", "Message", MessageBoxButtons.OK);
            }
        }

        private void EventsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void UpBtn_Click(object sender, EventArgs e)
        {
            //move up
            MoveItem(-1);
        }

        public void MoveItem(int direction)
        {
            if (eventsBox.SelectedItem == null || eventsBox.SelectedIndex < 0)
                return; //no selected item

            int newIndex = eventsBox.SelectedIndex + direction;

            if (newIndex < 0 || newIndex >= eventsBox.Items.Count)
                return;

            object selected = eventsBox.SelectedItem;

            //removing removable element
            eventsBox.Items.Remove(selected);
            //inserts in new location
            eventsBox.Items.Insert(newIndex, selected);
            //restore selection
            eventsBox.SetSelected(newIndex, true);
        }

        private void DownBtn_Click(object sender, EventArgs e)
        {
            //move down
            MoveItem(1);
        }

        private void EventsBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (eventsBox.SelectedItem != null)
            {
                selectedEvent.Text = eventsBox.SelectedItem.ToString();
                toolTip1.SetToolTip(eventsBox, eventsBox.SelectedItem.ToString());
            }
        }

        private void EventsBox_Click(object sender, EventArgs e)
        {

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            //clear
            if (MessageBox.Show("Clear all events?", "Clear?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                selectedEvent.Text = "";
                eventsBox.Items.Clear();
            }
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            selectedEvent.Text = "";

            //remove selected items from events
            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(eventsBox);

            if (eventsBox.SelectedIndex != -1)
            {
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                    eventsBox.Items.Remove(selectedItems[i]);
            }
            else
            {

            }
        }

        private void Schedule_FormClosing(object sender, FormClosingEventArgs e)
        {
            memory.Text = "";

            //when form is closing
            foreach (var item in eventsBox.Items)
            {
                memory.AppendText(item.ToString());
                memory.AppendText(Environment.NewLine);
            }

            Properties.Settings.Default.mem = memory.Text;
            Properties.Settings.Default.Save();
        }

        private void Schedule_Load(object sender, EventArgs e)
        {
            memory.Text = Properties.Settings.Default.mem;

            foreach (var line in memory.Lines)
            {
                if (line.ToString() != "")
                {
                    eventsBox.Items.Add(line.ToString());
                }
            }
        }
    }
}