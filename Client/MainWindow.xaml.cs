using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Contracts;
using System.ServiceModel;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;

namespace Client
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Contact contact1 = new Contact() { Name = "Miao" };
            Contact contact2 = new Contact() { Name = "Dick" };
            Contact contact3 = new Contact() { Name = "John" };

            Contact contact4 = new Contact() { Name = "Chen" };
            Contact contact5 = new Contact() { Name = "Zhang" };
            contact6 = new Contact() { Name = "Fuck" };

            ContactGroup group1 = new ContactGroup() { Name = "Classmate"};
            group1.Members.Add(contact1);
            group1.Members.Add(contact2);
            group1.Members.Add(contact3);

            group2 = new ContactGroup() { Name = "Families"};
            group2.Members.Add(contact4);
            group2.Members.Add(contact5);
            group2.Members.Add(contact6);

            groups = new ObservableCollection<ContactGroup>();
            groups.Add(group1);
            groups.Add(group2);

            tvContacts.ItemsSource = groups;

        }

        ContactGroup group2;
        Contact contact6;
        ObservableCollection<ContactGroup> groups;
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            group2.Members.Add(new Contact() { Name = "Mihiro" });
            contact6.Name = "Nitch";
            groups.Add(new ContactGroup() { Name = "sssss" });
        }
    }
}
