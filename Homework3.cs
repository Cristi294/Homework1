using System;
using System.Collections.Generic;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            User C = new User
            {
                Id = 1999,
                FirstName = "Ion",
                LastName = "Alexandru",
                Email = "iona@yahoo.com",
                Password = "soarevara"

            };


            Post post1 = new Post
            {
                Id = 1,
                Author = ,
                Message = "Nothing",
                Date = new DateTime(2018, 6, 05)

            };

            Board mainBoard = new Board();
            mainBoard.Posts = new List<Post>();
            mainBoard.Posts.Add(post1);

            Console.WriteLine(post1);
        }


        // Clasa USER
        public class User
        {
        
            private int CodPersonal;
            private string Nume;
            private string Prenume;
            private string email;
            private string parola;

            public int Id           { get; set; }
            public string FirstName { get; set; }
            public string LastName  { get; set; }
            public string Email     { get; set; }
            public string Password  { get; set; }

            public User() { }

            public User(int CodPersonal, string Nume, string Prenume, string parola, string email)
            {
                this.Id = CodPersonal;
                this.FirstName = Nume;
                this.LastName = Prenume;
                this.Email = email;
                this.Password = parola;
            }
        }

        // Clasa POST
        public class Post
        {
            private int id;
            private User Autor;
            private string Text;
            private DateTime Data;

            public int Id         { get; set; }
            public User Author    { get; set; }
            public string Message { get; set; }
            public DateTime Date  { get; set; }

            public Post() { }

            public Post(int id, User Autor, string Text, DateTime Data)
            {
                this.Id = id;
                this.Author = Autor;
                this.Message = Text;
                this.Date = Data;

            }
        }

        // Clasa BOARD
        public class Board
        {
            private List<Post> osts;

            public List<Post> Posts { get; set; }

            public Board() { }
        }
    }
}