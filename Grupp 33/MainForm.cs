using BLL;
using MODELS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grupp_33
{
    public partial class MainForm : Form
    {
        private Media selectedPodcastLV;
        private Category selectedCategoryLV;
        private Timer timer = new Timer();
        public MediaController mediaController = new MediaController();
        public CategoryController categoryController = new CategoryController();

        public MainForm()
        {
            InitializeComponent();

            listViewCat.View = View.Details;
            listViewCat.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewCat.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewPod.View = View.Details;
            listViewPod.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewPod.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            listViewPod.FullRowSelect = true;
            listViewEp.FullRowSelect = true;

           
            LoadPodListView();
            LoadCategoryListView();

            timer.Interval = 1000;
            timer.Tick += TimerEvent;
            timer.Start();




        }
       

        private async void btnPodCreate_Click(object sender, EventArgs e)
        {
            timer.Stop();
            PodCreateForm podCreateForm = new PodCreateForm();
            Media podcast = podCreateForm.GetNewPodcast();

            if (!Validation.isNull(podcast))
            {   
                
                    var boolResult = await mediaController.FetchNewPodcastAsync(podcast);
                    fillPodListview(mediaController.GetAllPodcasts());
                
                
            }

            timer.Start();
        }

        private void btnCatCreate_Click(object sender, EventArgs e)
        {

            CatCreateForm catCreateForm = new CatCreateForm();
            string catName = catCreateForm.GetNewCategory();
            if (!Validation.isNull(catName))
            {
                fillCatListview(categoryController.GetAllCategories());
            }
            
        }

        private void btnCatSave_Click(object sender, EventArgs e)
        {
            if (listViewCat.SelectedItems.Count > 0) 
            {
                if (!Validation.CheckEmptyTxt(txtCat.Text) && !Validation.ContainsWhiteSpace(txtCat.Text))
                {

                    string oldName = listViewCat.SelectedItems[0].Text;

                    categoryController.UpdateCategoryName(oldName, txtCat.Text);
                    mediaController.UpdatePodcastCat(oldName, txtCat.Text);

                    fillPodListview(mediaController.GetAllPodcasts());
                    fillCatListview(categoryController.GetAllCategories());
                    txtEpDes.Text = "";
                    listViewEp.Items.Clear();
                }
            }
        }

        private void btnPodSave_Click(object sender, EventArgs e)
        {
            if (listViewPod.SelectedItems.Count > 0)
            {
                mediaController.GetAllPodcasts();
                timer.Stop();
                if(selectedPodcastLV.Name == txtName.Text) 
                {
                    Category category = categoryController.GetCategoryByName(coBoxCat.Text);
                    mediaController.UpdatePodCastByName(category, Int32.Parse(coBoxFreq.Text + "000"), selectedPodcastLV.Name, txtName.Text);

                    selectedPodcastLV.Category = category;
                    selectedPodcastLV.UpdateFrequency = Int32.Parse(coBoxFreq.Text + "000");
                    selectedPodcastLV.Name = txtName.Text;

                    fillPodListview(mediaController.GetAllPodcasts());
                    txtEpDes.Text = "";
                    listViewEp.Items.Clear();
                }
                else
                {
                    if (!Validation.CheckEmptyTxt(txtName.Text) && !Validation.isPodcastNameTaken(txtName.Text) && !Validation.ContainsWhiteSpace(txtName.Text))
                    {
                        Category category = categoryController.GetCategoryByName(coBoxCat.Text);
                        mediaController.UpdatePodCastByName(category, Int32.Parse(coBoxFreq.Text + "000"), selectedPodcastLV.Name, txtName.Text);

                        selectedPodcastLV.Category = category;
                        selectedPodcastLV.UpdateFrequency = Int32.Parse(coBoxFreq.Text + "000");
                        selectedPodcastLV.Name = txtName.Text;

                        fillPodListview(mediaController.GetAllPodcasts());
                        txtEpDes.Text = "";
                        listViewEp.Items.Clear();
                    }
                }
                
                timer.Start();
            }    
        }
        private void LoadPodListView()
        {
            List<Media> list = mediaController.GetAllPodcasts();
            foreach (var item in list)
            {
                item.UpdateTheInterval();
            }
            fillPodListview(list);
        }

        private void LoadPodListViewSortedByCategory(List<Media> podlist)
        {
            
            fillPodListview(podlist);
        }

        private void LoadCategoryListView()
        {
            fillCatListview(categoryController.GetAllCategories());
        }

        public void fillPodListview(List<Media> PodList)
        {
            listViewPod.Items.Clear();
            listViewPod.View = View.Details;
            listViewPod.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewPod.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

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
                var podRow = listViewPod.SelectedItems[0];
                string name = podRow.Text;

                Media selectedPod = mediaController.GetPodByName(name);
                List<Item> itemList = selectedPod.items;
                selectedPodcastLV =  selectedPod;
                
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
                var epRow = listViewEp.SelectedItems[0];
                string name = epRow.Text;
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
            foreach (var item in mediaController.GetAllPodcasts())
            {
                bool checkUpdate = item.CheckIfUpdate();
                
                if (checkUpdate == true)
                {
                    var awaitTask = await Task.FromResult(mediaController.FetchPodcastIntervalAsync(item));
                    item.UpdateTheInterval();


                    if (listViewPod.SelectedItems.Count <= 0)
                    {
                        fillPodListview(mediaController.GetAllPodcasts());
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

                LoadPodListViewSortedByCategory(mediaController.GetAllPodcastByCat(catName));


                selectedCategoryLV = categoryController.GetCategoryByName(catName);
            }
            else
            {
                fillPodListview(mediaController.GetAllPodcasts());
            }
        }

        private void btnCatDelete_Click(object sender, EventArgs e)
        {
            if (listViewCat.SelectedItems.Count > 0)
            {
                timer.Stop();
                List<Category> fullList = categoryController.GetAllCategories();

                if (fullList.Count() > 1)
                {

                    string catName = listViewCat.SelectedItems[0].Text;

                    Category deleteThis = categoryController.GetCategoryByName(catName);
                    List<Media> deletePodList = new List<Media>();
                    deletePodList = mediaController.GetAllPodcastByCat(deleteThis.Name);
                    string deleteNames = "\n";

                    foreach (Media item in deletePodList)
                    {
                        deleteNames += item.Name + "\n";
                    }
                    DialogResult dr = MessageBox.Show("Är du säker att du vill ta bort följande podcasts?" + deleteNames, "Ta bort", MessageBoxButtons.YesNo);
                    switch (dr)
                    {
                        case DialogResult.Yes:
                            mediaController.DeleteOnCategory(deleteThis);
                            categoryController.DeleteCategoryOnName(deleteThis.Name);

                            fillCatListview(categoryController.GetAllCategories());
                            fillPodListview(mediaController.GetAllPodcasts());
                            txtEpDes.Text = "";
                            listViewEp.Items.Clear();
                            break;

                        case DialogResult.No:
                            break;
                    }
                    timer.Start();
                }
                else {
                    MessageBox.Show("Du försöker ta bort den sista kategorin! Skapa en ny och ta sedan bort denna.");
                }
            }
        }

        private void btnPodDelete_Click(object sender, EventArgs e)
        {
            if(listViewPod.SelectedItems.Count > 0)
            {
                timer.Stop();

                string podName = listViewPod.SelectedItems[0].Text;

                mediaController.DeletePodOnName(podName);

                fillPodListview(mediaController.GetAllPodcasts());
                txtEpDes.Text = "";
                listViewEp.Items.Clear();
                timer.Start();

            }
        }
    }
}
