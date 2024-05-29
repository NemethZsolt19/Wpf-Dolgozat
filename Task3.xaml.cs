using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf_Dolgozat
{
    /// <summary>
    /// Interaction logic for Task3.xaml
    /// </summary>
    public partial class Task3 : UserControl
    {

            private DbContext _context;
            private Entity _selectedEntity;

            public UserControl()
            {
                InitializeComponent();
                _context = new DbContext();
                LoadData();
            }

            private void LoadData()
            {
                DataListBox.ItemsSource = _context.Entities.ToList();
            }

            private void DataListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
            {
                _selectedEntity = DataListBox.SelectedItem as Entity;
                if (_selectedEntity != null)
                {
                    DataTextBox.Text = _selectedEntity.DataField;
                }
            }

            private void UpdateButton_Click(object sender, RoutedEventArgs e)
            {
                if (_selectedEntity != null)
                {
                    _selectedEntity.DataField = DataTextBox.Text;
                    _context.SaveChanges();
                    LoadData();
                }
            }

            private void DeleteButton_Click(object sender, RoutedEventArgs e)
            {
                if (_selectedEntity != null)
                {
                    _context.Entities.Remove(_selectedEntity);
                    _context.SaveChanges();
                    LoadData();
                }
            }
        }
    }


