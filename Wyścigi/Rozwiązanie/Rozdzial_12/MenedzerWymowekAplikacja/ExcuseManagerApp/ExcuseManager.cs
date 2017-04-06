using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenedzerWymowekAplikacja
{
    using System.ComponentModel;
    using System.IO;
    using System.Runtime.Serialization;
    using Windows.Storage;
    using Windows.Storage.Streams;
    using Windows.Storage.FileProperties;
    using Windows.Storage.Pickers;
    using Windows.UI.Popups;

    class ExcuseManager
    {
        public Excuse CurrentExcuse { get; set; }

        public string FileDate { get; private set; }

        private Random random = new Random();

        private IStorageFolder excuseFolder = null;

        private IStorageFile excuseFile;

        public ExcuseManager()
        {
            NewExcuseAsync();
        }

        async public void NewExcuseAsync()
        {
            CurrentExcuse = new Excuse();
            excuseFile = null;
            OnPropertyChanged("CurrentExcuse");
            await UpdateFileDateAsync();
        }

        public void SetToCurrentTime()
        {
            CurrentExcuse.LastUsed = DateTimeOffset.Now.ToString();
            OnPropertyChanged("CurrentExcuse");
        }

        public async Task<bool> ChooseNewFolderAsync()
        {
            FolderPicker folderPicker = new FolderPicker()
            {
                SuggestedStartLocation = PickerLocationId.DocumentsLibrary
            };
            folderPicker.FileTypeFilter.Add(".xml");
            IStorageFolder folder = await folderPicker.PickSingleFolderAsync();
            if (folder != null)
            {
                excuseFolder = folder;
                return true;
            }
            MessageDialog warningDialog = new MessageDialog("Nie wybrano folderu wymówek");
            await warningDialog.ShowAsync();
            return false;
        }

        public async void OpenExcuseAsync()
        {
            FileOpenPicker picker = new FileOpenPicker
            {
                SuggestedStartLocation = PickerLocationId.DocumentsLibrary,
                CommitButtonText = "Otwórz plik wymówki"
            };
            picker.FileTypeFilter.Add(".xml");
            excuseFile = await picker.PickSingleFileAsync();
            if (excuseFile != null)
                await ReadExcuseAsync();
        }

        public async void OpenRandomExcuseAsync()
        {
            IReadOnlyList<IStorageFile> files = await excuseFolder.GetFilesAsync();
            if (files.Count() == 0)
            {
                await new MessageDialog("Aktualnie folder wymówek jest pusty.").ShowAsync();
                return;
            }
            excuseFile = files[random.Next(0, files.Count())];
            await ReadExcuseAsync();
        }

        public async Task UpdateFileDateAsync()
        {
            if (excuseFile != null)
            {
                BasicProperties basicProperties = await excuseFile.GetBasicPropertiesAsync();
                FileDate = basicProperties.DateModified.ToString();
            }
            else
                FileDate = "(nie wycztano pliku)";
            OnPropertyChanged("FileDate");
        }

        public async void SaveCurrentExcuseAsync()
        {
            if (CurrentExcuse == null)
            {
                await new MessageDialog("Nie wczytano wymówki").ShowAsync();
                return;
            }
            if (String.IsNullOrEmpty(CurrentExcuse.Description))
            {
                await new MessageDialog("Bieżąca wymówka nie ma opisu").ShowAsync();
                return;
            }
            if (excuseFile == null)
                excuseFile = await excuseFolder.CreateFileAsync(CurrentExcuse.Description + ".xml",
                                   CreationCollisionOption.ReplaceExisting);

            await WriteExcuseAsync();
        }
         
        public async Task ReadExcuseAsync() 
        { 
            try
            {
                using (IRandomAccessStream stream = 
                        await excuseFile.OpenAsync(FileAccessMode.Read)) 
                using (Stream inputStream = stream.AsStreamForRead()) 
                { 
                    DataContractSerializer serializer 
                                = new DataContractSerializer(typeof(Excuse)); 
                    CurrentExcuse = serializer.ReadObject(inputStream) as Excuse; 
                } 
                 
                await new MessageDialog("Wymówka odczytana z pliku " 
                                          + excuseFile.Name).ShowAsync(); 
                OnPropertyChanged("CurrentExcuse"); 
                await UpdateFileDateAsync(); 
            } 
            catch (SerializationException) 
            { 
                new MessageDialog("Nie udało się odczytać pliku " + excuseFile.Name).ShowAsync();
            } 
             
        } 
         
        public async Task WriteExcuseAsync() 
        { 
            using (IRandomAccessStream stream =
                    await excuseFile.OpenAsync(FileAccessMode.ReadWrite))
            using (Stream outputStream = stream.AsStreamForWrite())
            {
                DataContractSerializer serializer = new DataContractSerializer(typeof(Excuse));
                serializer.WriteObject(outputStream, CurrentExcuse);
            }
            await new MessageDialog("Wymówka została zapisana w pliku " + excuseFile.Name).ShowAsync();
            await UpdateFileDateAsync();
        }

        public async void SaveCurrentExcuseAsAsync()
        {
            FileSavePicker picker = new FileSavePicker
            {
                SuggestedStartLocation = PickerLocationId.DocumentsLibrary,
                SuggestedFileName = CurrentExcuse.Description,
                CommitButtonText = "Zapisz plik wymówki"
            };
            picker.FileTypeChoices.Add("XML File", new List<string>() { ".xml" });
            IStorageFile newExcuseFile = await picker.PickSaveFileAsync();
            if (newExcuseFile != null)
            {
                excuseFile = newExcuseFile;
                await WriteExcuseAsync();
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChangedEvent = PropertyChanged;
            if (propertyChangedEvent != null)
            {
                propertyChangedEvent(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
