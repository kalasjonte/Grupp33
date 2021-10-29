using BLL;
using MODELS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupp_33
{
    public partial class MainForm : Form
    {
        private Podcast selectedPodcastLV;
        private Category selectedCategoryLV;
        private Timer timer = new Timer();
        public PodcastController podcontroll = new PodcastController();
        public CategoryController categoryController = new CategoryController();

        public MainForm()
        {
            InitializeComponent();

            listViewCat.View = View.Details;
            listViewCat.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewCat.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewPod.FullRowSelect = true;
            listViewEp.FullRowSelect = true;

            LoadPodListView();
            LoadCategoryListView();
            timer.Interval = 1000;
            timer.Tick += TimerEvent;
            timer.Start();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private async void btnPodCreate_Click(object sender, EventArgs e)
        {
            timer.Stop();
            PodCreateForm podCreateForm = new PodCreateForm();
            Podcast podcast = (Podcast)podCreateForm.GetNewPodcast();

            if (!Validation.isNull(podcast))
            {
                var boolresultat = await podcontroll.FetchNewPodcastAsync(podcast);

                fillPodListview(podcontroll.GetAllPodcasts());
            }
            
            timer.Start();
        }

        private void btnCatCreate_Click(object sender, EventArgs e)
        {

            CatCreateForm catCreateForm = new CatCreateForm();
            string catname = catCreateForm.GetNewCategory();
            if (!Validation.isNull(catname))
            {
                fillCatListview(categoryController.GetAllCategories());
            }
            
        }

        private void btnCatSave_Click(object sender, EventArgs e)
        {
            if (listViewCat.SelectedItems.Count > 0)
            {
                string oldName = listViewCat.SelectedItems[0].Text;

                categoryController.UpdateCategoryName(oldName, txtCat.Text);
                podcontroll.UpdatePodcastCat(oldName, txtCat.Text);

                fillPodListview(podcontroll.GetAllPodcasts());
                fillCatListview(categoryController.GetAllCategories());
                txtEpDes.Text = "";
                listViewEp.Items.Clear();
            }
        }

        private void btnPodSave_Click(object sender, EventArgs e)
        {
            if (listViewPod.SelectedItems.Count > 0)
            {
                timer.Stop();
                if (!Validation.CheckEmptyTxt(txtName.Text) && !Validation.isPodcastNameTaken(txtName.Text))
                {
                    Category category = categoryController.GetCategoryByName(coBoxCat.Text);
                    podcontroll.UpdatePodCastByName(category, Int32.Parse(coBoxFreq.Text + "000"), selectedPodcastLV.Name, txtName.Text);

                    selectedPodcastLV.Category = category;
                    selectedPodcastLV.UpdateFrequency = Int32.Parse(coBoxFreq.Text + "000");
                    selectedPodcastLV.Name = txtName.Text;

                    fillPodListview(podcontroll.GetAllPodcasts());
                    txtEpDes.Text = "";
                    listViewEp.Items.Clear();
                }
                timer.Start();
            }    
        }
        private void LoadPodListView()
        {
            foreach (var item in podcontroll.GetAllPodcasts())
            {
                item.UpdateTheInterval();
                Console.WriteLine(item.Update);
            }
            fillPodListview(podcontroll.OrderByDescending());
        }

        private void LoadPodListViewSortedByCategory(List<Podcast> podlist)
        {
            var queryDescend = from pod in podlist
                               orderby pod.Name
                               select pod;
            podlist = queryDescend.ToList();
            fillPodListview(podlist);
        }

        private void LoadCategoryListView()
        {
            fillCatListview(categoryController.GetAllCategories());
        }

        public void fillPodListview(List<Podcast> PodList)
        {
            listViewPod.Items.Clear();
            listViewPod.View = View.Details;
            listViewPod.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewPod.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            //listViewPod.FullRowSelect = true;

            foreach (var pod in PodList)
            {
                ListViewItem item1 = new ListViewItem(pod.Name, 0);
                item1.SubItems.Add(pod.NumberOfItems.ToString());
                item1.SubItems.Add(pod.UpdateFrequency.ToString());
                item1.SubItems.Add(pod.Category.Name);

                listViewPod.Items.Add(item1);
            }
        }

        public void fillCatListview(List<Category> catList)
        {
            listViewCat.Items.Clear();
            listViewCat.View = View.Details;
            listViewCat.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewCat.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            foreach (var cat in catList)
            {
                ListViewItem item1 = new ListViewItem(cat.Name, 0);
                listViewCat.Items.Add(item1);
            }
        }

        private void listViewPod_SelectedIndexChanged(object sender, EventArgs e)
        {
            listViewEp.Items.Clear();
            txtName.Text = " ";

            if (listViewPod.SelectedItems.Count > 0)
            {
                var podrad = listViewPod.SelectedItems[0];
                string name = podrad.Text; // == namnet på podden

                Podcast selectedPod = podcontroll.GetPodByName(name);
                selectedPodcastLV = selectedPod;
                List<Item> itemList = selectedPod.items;
                LoadEpListView(itemList);

                txtName.Text = selectedPod.Name;
                switch (selectedPod.UpdateFrequency)
                {
                    case 15000:
                        coBoxFreq.SelectedIndex = 0;
                        break;

                    case 30000:
                        coBoxFreq.SelectedIndex = 1;
                        break;

                    case 60000:
                        coBoxFreq.SelectedIndex = 2;
                        break;

                    default:
                        coBoxFreq.SelectedIndex = 0;
                        break;
                }

                coBoxCat.Items.Clear();
                foreach (var item in categoryController.GetAllCategories())
                {
                    coBoxCat.Items.Add(item.Name);
                }
                
                coBoxCat.SelectedIndex = coBoxCat.FindStringExact(selectedPod.Category.Name);
            }
            else
            {
                fillPodListview(podcontroll.GetAllPodcasts());
                txtEpDes.Text = "";
                txtName.Text = "";
                coBoxFreq.SelectedIndex = 0;
                coBoxCat.SelectedIndex = 0;

            }
        }

        private void LoadEpListView(List<Item> itemList)
        {
            listViewEp.View = View.Details;
            listViewEp.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewEp.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            foreach (var ep in itemList)
            {
                ListViewItem item = new ListViewItem(ep.Name, 0);
                listViewEp.Items.Add(item);
            }
        }

        private void listViewEp_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtEpDes.Text = "";

            if (listViewEp.SelectedItems.Count > 0)
            {
                var eprad = listViewEp.SelectedItems[0];
                string name = eprad.Text; // == namnet på avsnittet
                List<Item> items = selectedPodcastLV.items;

                var query = from item in items
                            where item.Name == name
                            select item.Guid;

                string guid = query.First();
                var query2 = from item2 in items
                             where item2.Guid == guid
                             select item2.Description;

                string description = query2.First();
                txtEpDes.Text = description;
            }
        }

        private async void TimerEvent(object sender, EventArgs e)
        {
            foreach (var item in podcontroll.GetAllPodcasts())
            {
                bool check = item.CheckIfUpdate();
               
                if (check == true)
                {
                    var bulle = await Task.FromResult(podcontroll.FetchPodcastIntervalAsync(item));
                    item.UpdateTheInterval();

                    if (listViewPod.SelectedItems.Count < 0)
                    {
                        fillPodListview(podcontroll.OrderByDescending());
                    }
                }
            }
        }

        private void listViewCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewCat.SelectedItems.Count > 0)
            {
                listViewEp.Items.Clear();
                txtEpDes.Text = "";
                string catName = listViewCat.SelectedItems[0].Text;

                LoadPodListViewSortedByCategory(podcontroll.GetAllPodcastByCat(catName));

                var catQuery = from cat in categoryController.GetAllCategories()
                               where cat.Name == catName
                               select cat;

                selectedCategoryLV = catQuery.First();
            }
            else
            {
                fillPodListview(podcontroll.GetAllPodcasts());
            }
        }

        private void btnCatDelete_Click(object sender, EventArgs e)
        {
            if (listViewCat.SelectedItems.Count > 0)
            {
                timer.Stop();
                string catName = listViewCat.SelectedItems[0].Text;

                Category deletethis = categoryController.GetCategoryByName(catName);
                List<Podcast> deletepodlist = new List<Podcast>();
                deletepodlist = podcontroll.GetAllPodcastByCat(deletethis.Name);
                string deletenames = "\n";
                foreach (Podcast item in deletepodlist)
                {
                    deletenames += item.Name + "\n";
                }
                DialogResult dr = MessageBox.Show("Är du säker att du vill ta bort följande podcasts?" + deletenames, "Ta bort", MessageBoxButtons.YesNo);
                switch(dr)
                {
                    case DialogResult.Yes:
                podcontroll.DeleteOnCategory(deletethis);
                categoryController.DeleteCategoryOnName(deletethis.Name);

                fillCatListview(categoryController.GetAllCategories());
                fillPodListview(podcontroll.GetAllPodcasts());
                txtEpDes.Text = "";
                listViewEp.Items.Clear();
                        break;

                    case DialogResult.No:
                        break;
                }
                timer.Start();
            }
        }

        private void btnPodDelete_Click(object sender, EventArgs e)
        {
            if(listViewPod.SelectedItems.Count > 0)
            {
                timer.Stop();

                string podName = listViewPod.SelectedItems[0].Text;

                podcontroll.DeletePodOnName(podName);

                fillPodListview(podcontroll.GetAllPodcasts());
                txtEpDes.Text = "";
                listViewEp.Items.Clear();
                timer.Start();

            }
        }
    }
}
