using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;

namespace VocabAid_WP.ViewModels
{
    public abstract class ViewModelBase <TItemType> // : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void RaisePropertyChanged(string propertyName)
        {
            var handler = this.PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }   


        //private SQLiteConnection sqliteConn = new SQLiteConnection("MainDB.db");
/*        protected abstract string GetStatement(bool allItems);

        protected abstract TItemType CreateItem(SQLiteWinRT.Statement statement);

        public async Task<TItemType> GetItem(int key)
        {
            var db = await App.GetDatabaseAsync();
            using (var statement = await db.PrepareStatementAsync(GetStatement(false)))
            {
                statement.BindIntParameterAt(1, key);
                if (await statement.StepAsync())
                {
                    var item = CreateItem(statement);
                    return item;
                }
            }
            throw new ArgumentOutOfRangeException("Key not found");
        }

        public async Task<ObservableCollection<TItemType>> GetAllItems()
        {
            var items = new ObservableCollection<TItemType>();
            var db = await App.GetDatabaseAsync();
            SQLiteWinRT.Statement statement = await db.PrepareStatementAsync("SELECT Word FROM Words;");
            using (statement = await db.PrepareStatementAsync(GetStatement(true)))
            {
                while (await statement.StepAsync())
                {
                    var item = CreateItem(statement);
                    items.Add(item);
                }
            }

            return items;
        } */
    }



}
