using MyBlock.BL;
using MyBlock.BL.AssemblyLines;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBlock
{
    public partial class MainForm : Form
    {
        private IPresenter Presenter { get; set; } = new Presenter();
        #region Auxiliary
        private bool Valid(Control control, IValidationInfo validateInfo)
        {
            errorProvider.Clear();
            if (validateInfo.IsValid) return true;
            errorProvider.SetError(control, validateInfo.Message);
            MessageBox.Show(validateInfo.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private IEnumerable<ListViewItem> GetItems(ListView list, bool selectedOnly) =>
            selectedOnly ? list.SelectedItems.Cast<ListViewItem>().ToArray() : list.Items.Cast<ListViewItem>().ToArray();
        private ISiteRecord GetOneRecord(ListViewItem item) => (ISiteRecord)item.Tag;
        private IEnumerable<ISiteRecord> GetRecords(IEnumerable<ListViewItem> items) => items.Select(o => GetOneRecord(o));
        private void MoveItems(ListView sourcetList, ListView targetTist, IEnumerable<ListViewItem> sourceItems)
        {
            foreach (ListViewItem item in sourceItems)
            {
                sourcetList.Items.Remove(item);
                targetTist.Items.Add(item);
            }
        }
        #endregion
        public MainForm()
        {
            InitializeComponent();
            Presenter.AssemblyFromWebLine.BuildingComplete += AssamblyFromWebLine_BuildingComplete;
            Presenter.AssemblyFromFileLine.BuildingComplete += AssamblyFromWebLine_BuildingComplete;
            if (!Presenter.RoleCheck.CheckAdministratrRole())
            {
                MessageBox.Show("Run this program 'as Administrator'!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (Application.MessageLoop) Application.Exit();
                else Environment.Exit(1);
            }
            Presenter.LoadFromFile();
        }
        #region Event Handlers
        private void AssamblyFromWebLine_BuildingComplete(object? sender, ISiteRecord record)
        {
            if (record.SiteModel.Favicon != null) imageList.Images.Add(record.SiteModel.Host, record.SiteModel.Favicon);
            var item = new ListViewItem(new string[] { "", record.SiteModel.Name, record.SiteModel.Host, record.TimeLeft }, record.SiteModel.Host) { Tag = record };
            if (record.IsForbidden) listViewForbidden.Items.Add(item);
            else listViewAllow.Items.Add(item);
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            textBoxUrl.Text = textBoxUrl.Text.Trim();
            Presenter.AssemblyFromWebLine.InitTable();
            if (!Valid(textBoxUrl, Presenter.AssemblyFromWebLine.SetUrl(
                textBoxUrl.Text, Presenter.ForbiddenList.Select(o => o.SiteModel.Host)))) return;
            var dateForm = new DateForm() { Presenter = Presenter };
            if (dateForm.ShowDialog() != DialogResult.OK) return;
            textBoxUrl.Text = "";
            Presenter.AssemblyFromWebLine.StartAssembly();
        }
        private void buttonUnForbidden_Click(object sender, EventArgs e)
        {
            var items = GetItems(listViewForbidden, true);
            Presenter.MoveItems(GetRecords(items), false);
            MoveItems(listViewForbidden, listViewAllow, items);
        }
        private void buttonForbidden_Click(object sender, EventArgs e)
        {
            var items = GetItems(listViewAllow, true);
            Presenter.MoveItems(GetRecords(items), true);
            MoveItems(listViewAllow, listViewForbidden, items);
        }
        private void buttonUnforbiddenAll_Click(object sender, EventArgs e)
        {
            var items = GetItems(listViewForbidden, false);
            Presenter.MoveItems(GetRecords(items), false);
            MoveItems(listViewForbidden, listViewAllow, items);
        }
        private void buttonForbiddenAll_Click(object sender, EventArgs e)
        {
            var items = GetItems(listViewAllow, false);
            Presenter.MoveItems(GetRecords(items), true);
            MoveItems(listViewAllow, listViewForbidden, items);
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            foreach (var item in listViewAllow.SelectedItems)
            {
                listViewAllow.Items.Remove((ListViewItem)item);
                var record = GetOneRecord((ListViewItem)item);
                Presenter.Remove(record);
            }
        }
        #endregion
    }
}
