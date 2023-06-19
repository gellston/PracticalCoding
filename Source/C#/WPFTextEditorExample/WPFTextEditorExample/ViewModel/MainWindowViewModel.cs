using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WPFTextEditorExample.Command;

namespace WPFTextEditorExample.ViewModel
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        #region Private Property
        public event PropertyChangedEventHandler? PropertyChanged;
        private string _Content = "";
        private string _FilePath = "";
        #endregion

        #region Constructor
        public MainWindowViewModel() { 
        
        }
        #endregion

        #region Public Property
        public void OnRaiseProperty(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }


        public string Content
        {
            get => _Content;
            set
            {
                _Content = value;
                OnRaiseProperty(nameof(Content));
            }
        }

        public string FilePath
        {
            get => _FilePath;
            set
            {
                _FilePath = value;
                OnRaiseProperty(nameof(FilePath));
            }
        }
        #endregion

        #region Command
        public ICommand OpenFileCommand
        {
            get => new RelayCommand((arg) =>
            {
                try
                {

                    OpenFileDialog openFileDialog = new OpenFileDialog();
                    openFileDialog.Filter = "Text files (*.txt)|*.txt";
                    openFileDialog.Multiselect = false;
                    if (openFileDialog.ShowDialog() == true)
                    {

                        var filePath = openFileDialog.FileName;
                        var fileName = Path.GetFileName(filePath);
                        this.FilePath = filePath;
                        this.Content = File.ReadAllText(filePath);
                        MessageBox.Show("성공적으로 로드되었습니다.");
                    }

                }
                catch(Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                }
            });
        }

        public ICommand SaveFileCommand
        {
            get => new RelayCommand((arg) =>
            {
                try
                {
                    if(File.Exists(this.FilePath) == true)
                    {


                        File.WriteAllText(this.FilePath, this.Content);
                        MessageBox.Show("성공적으로 저장되었습니다.");
                    }

                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(ex.Message);
                }
            });
        }
        #endregion


    }
}
