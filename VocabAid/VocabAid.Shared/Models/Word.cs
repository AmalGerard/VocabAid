
namespace VocabAid_WP.Models
{
    public class WordModel
    {
        private long id;
        public long Id
        {
            get { return id; }
        }

        private string word;
        public string Word
        {
            get { return word; }
        }

        private string alpha;
        public string Alpha
        {
            get { return alpha; }
        }

        internal WordModel() { }

        internal WordModel(long id, string word, string alpha)
        {
            this.id = id;
            this.word = word;
            this.alpha = alpha;
        }
    }
}
