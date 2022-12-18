using Xplore.Data;
using Xplore.Models;

namespace Xplore
{
    public class Seed
    {
        private readonly DataContext _dataContext;
        public Seed(DataContext context)
        {
            _dataContext = context;
        }

        public void SeedDataContext()
        {
            if(!_dataContext.BookListBooks.Any())
            {
                var BookListBooks = new List<BookList_Book>()
                {
                    new BookList_Book()
                    {
                        Book = new Book()
                        {
                            Title = "The Offspring of a Bloodmoon.",
                            Summary = "This is about a vampire",
                            Category = Enums.Category.FICTION,
                            Tags = "horror, supernatural, young adult",
                            Chapters = new List<Chapter>() 
                            {
                                new Chapter()
                                {
                                    Title = "Chapter One: The Creation",
                                    Blob = "Hey guys really happy to bring this story to you guys hope you enjoy it.",
                                    Rating = 100,
                                    DateCreated = new DateTime(),
                                    DateUpdated = new DateTime(),
                                    Content = "He sat in the corner, he's eyes lurking around as he paced over the wet slab on the road side waiting to...",
                                    Comments = new List<ChapterComment>()
                                    {
                                        new ChapterComment()
                                        {
                                            Content = "Really loving Jake's personality",
                                            DateCreated = new DateTime(),
                                            DateUpdated = new DateTime(),
                                            CommentAuthor = new User()
                                            {
                                                UserType = Enums.UserType.AUTHOR,
                                                Email = "cedarwudnovelza@gmail.com",
                                                PhoneNo = "+234435465775",
                                                About = "I am a writer",
                                                Dob =  new DateTime(2022, 1, 1),
                                                DateCreated = new DateTime(),
                                                DateUpdated = new DateTime(),
                                            }
                                        }
                                    }
                                }
                            },
                            BookAuthor = new User()
                            {
                                UserType = Enums.UserType.AUTHOR,
                                Email = "cedarwudnovelza@gmail.com",
                                PhoneNo = "+234435465775",
                                About = "I am a writer",
                                Dob =  new DateTime(2022, 1, 1),
                                DateCreated = new DateTime(),
                                DateUpdated = new DateTime(),
                                Posts = new List<Post>()
                                {
                                    new Post()
                                    {
                                        Content = "Hey, having issues writing",
                                        DateCreated = new DateTime(),
                                        DateUpdated = new DateTime(),
                                        PostComments = new List<PostComment>()
                                        {
                                            new PostComment()
                                            {
                                                Content = "Read More, it helps a lot",
                                                DateCreated = new DateTime(),
                                                DateUpdated = new DateTime()
                                            }
                                        }
                                    },
                                    new Post()
                                    {
                                        Content = "Hey, I don't have a pen",
                                        DateCreated = new DateTime(),
                                        DateUpdated = new DateTime(),
                                    }
                                }

                            }
                        },

                        BookList = new BookList()
                        {
                            Name = "Cedar's Fright Lib",
                            Owner = new User()
                            {
                                UserType = Enums.UserType.READER,
                                Email = "crazewriter@gmail.com",
                                PhoneNo = "+23443234775",
                                About = "I fucking love reading",
                                Dob =  new DateTime(2022, 1, 1),
                                DateCreated = new DateTime(),
                                DateUpdated = new DateTime(),
                            }
                        }

                    },
                    new BookList_Book()
                    {
                        Book = new Book()
                        {
                            Title = "The Devils Advocate.",
                            Summary = "Now she has to play devils advocate to get to the root of the murders in the community",
                            Category = Enums.Category.FICTION,
                            Tags = "horror, supernatural, mystery",
                            BookAuthor = new User()
                            {
                                UserType = Enums.UserType.AUTHOR,
                                Email = "crazewriter@gmail.com",
                                PhoneNo = "+23443234775",
                                About = "Writing is all I know how to do",
                                Dob =  new DateTime(2022, 1, 1),
                                DateCreated = new DateTime(),
                                DateUpdated = new DateTime(),
                                Posts = new List<Post>()
                                {
                                    new Post()
                                    {
                                        Content = "Hey, check out the new chapter of The Devils Advocate and things are getting heated",
                                        DateCreated = new DateTime(),
                                        DateUpdated = new DateTime(),
                                        PostComments = new List<PostComment>()
                                        {
                                            new PostComment()
                                            {
                                                Content = "Really loving the direction the books going.",
                                                DateCreated = new DateTime(),
                                                DateUpdated = new DateTime()
                                            }
                                        }
                                    },
                                    new Post()
                                    {
                                        Content = "Really hope Reaver doesn't die.",
                                        DateCreated = new DateTime(),
                                        DateUpdated = new DateTime(),
                                    }
                                }

                            }
                        },


                        BookList = new BookList()
                        {
                            Name = "Think Mystery",
                            Owner = new User()
                            {
                                UserType = Enums.UserType.BOTH,
                                Email = "mysterywriter@gmail.com",
                                PhoneNo = "+23343234775",
                                About = "I fucking love reading and writing",
                                Dob =  new DateTime(2022, 1, 1),
                                DateCreated = new DateTime(),
                                DateUpdated = new DateTime(),
                            }
                        }
                    },
                };
            }
        }
    }
}
