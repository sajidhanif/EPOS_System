namespace Shop_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.Red;
            radioButton2.ForeColor = System.Drawing.Color.Yellow;

            cmb_items.Items.Clear();
            cmb_items.Items.Add("apple");
            cmb_items.Items.Add("banana");
            cmb_items.Items.Add("vanilla");


        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.ForeColor = System.Drawing.Color.Yellow;
            radioButton2.ForeColor = System.Drawing.Color.Red;

            cmb_items.Items.Clear();
            cmb_items.Items.Add("oreo");
            cmb_items.Items.Add("mars");
            cmb_items.Items.Add("flake");


        }

        private void cmb_items_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_items.SelectedItem.ToString() == "apple")
            {
                txt_price.Text = "10";
            }

            else if (cmb_items.SelectedItem.ToString() == "banana")
            {
                txt_price.Text = "10";
            }

            else if(cmb_items.SelectedItem.ToString() == "vanilla")
            {
                txt_price.Text = "10";
            }

            else if(cmb_items.SelectedItem.ToString() == "oreo")
            {
                txt_price.Text = "222";
            }

            else if(cmb_items.SelectedItem.ToString() == "mars")
            {
                txt_price.Text = "222";
            }

            else if(cmb_items.SelectedItem.ToString() == "flake")
            {
                txt_price.Text = "222";
            }

            else
            {
                txt_price.Text = "0";
            }

            txt_total.Text = "";
            txt_qty.Text = "";



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (txt_qty.Text.Length > 0)
            {
                txt_total.Text = (Convert.ToInt16(txt_price.Text) * Convert.ToInt16(txt_qty.Text)).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string[] arr = new string[4];
            arr[0] = cmb_items.SelectedItem.ToString();
            arr[1] = txt_price.Text;
            arr[2] = txt_qty.Text;
            arr[3] = txt_total.Text;

            ListViewItem lvi = new ListViewItem(arr);

            listView1.Items.Add(lvi);

            txt_sub.Text = (Convert.ToInt16(txt_sub.Text) + Convert.ToInt16(txt_total.Text)).ToString();


           

        }

        private void txt_discount_TextChanged(object sender, EventArgs e)
        {

            if (txt_discount.Text.Length > 0)
            {
                txt_net.Text = (Convert.ToInt16(txt_sub.Text) - Convert.ToInt16(txt_discount.Text)).ToString();
            }

        }

        private void txt_net_TextChanged(object sender, EventArgs e)
        {   

        }

        private void txt_paid_TextChanged(object sender, EventArgs e)
        {
            if (txt_paid.Text.Length > 0)
            {
                txt_balance.Text = (Convert.ToInt16(txt_net.Text) - Convert.ToInt16(txt_paid.Text)).ToString();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count > 0)
            {

                for (int i = 0; i < listView1.Items.Count; i++)
                {

                    if (listView1.Items[i].Selected)
                    {
                        txt_sub.Text = (Convert.ToInt16(txt_sub.Text) - Convert.ToInt16(listView1.Items[i].SubItems[3].Text)).ToString();
                        listView1.Items[i].Remove();
                    }
                }


            }

        }
    }
}