using System;
namespace ClassExercises
{
    public class Post
    {
        //Properties of Post
        public string _postTitle;
        public string _postDescription { get; set; }
        public DateTime _postDate { get; private set; }
        public int AmtOfVotes;



        //Generic Post set
        public Post(string Title, string Description)
        {
            _postTitle = Title;
            _postDescription = Description;
            _postDate = DateTime.Now;

        }


        //Voting
        //Adds one vote up
        public void VoteUp()
        {
            AmtOfVotes += 1;
        }

        //Subtracts one vote down
        public void VoteDown()
        {
            AmtOfVotes -= 1;
        }

        public void showVotes()
        {
            Console.WriteLine($"Votes: {AmtOfVotes}");
        }
    }
}

