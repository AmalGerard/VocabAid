using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Text;
using VocabAid_WP.Models;

namespace VocabAid_WP.ViewModels
{
    public class WordsViewModel : ViewModelBase<WordModel>
    {
        private WordsViewModel() { }

        static WordsViewModel instance;
        public static WordsViewModel GetDefault()
        {
            lock (typeof(WordsViewModel))
            {
                if (instance == null)
                    instance = new WordsViewModel();
            }
            return instance;
        }

 /*       protected override string GetStatement(bool allItems)
        {
            string statement = "";
            if (allItems == true)
            {
                statement = "SELECT ID, Word, Alphabet FROM Words;";
            }
            else
            {
                statement = "SELECT ID, Word, Alphabet FROM Words WHERE ID = ?";
            }
            return statement;
        }

        protected override WordModel CreateItem(SQLiteWinRT.Statement statement)
        {
            var _word = new WordModel(statement.GetInt64At(0), statement.GetTextAt(1), statement.GetTextAt(2));
            return _word;
        } */
    }
}
