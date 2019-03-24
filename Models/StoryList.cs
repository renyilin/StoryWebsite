using System;
using System.Collections;
using System.Collections.Generic;

namespace StoryWebsite.Models
{
        public class StoryList : IEnumerable<Story>
        {
            public List<Story> storys { get; set; } = new List<Story>();

            private static StoryList instance { get; set; } = null;  // holds persistant instance

        private StoryList()
        {

            //----< Users >-----------------
            User user0 = new User()
            {
                userID = 0,
                userName = "Yilin Ren",
                password = "cxmnbxzmnkh",
                email = "yren20@syr.edu",
                avatarURL = "https://lucidchart.zendesk.com/system/photos/8933/3314/profile_image_678269360_201415.png"
            };

            User user1 = new User()
            {
                userID = 1,
                userName = "Jean van der Meulen",
                password = "a12mnsdfsafsa",
                email = "jvsm@gmail.com",
                avatarURL = "https://lucidchart.zendesk.com/system/photos/0003/5071/8906/profile_image_252411440_201415.png"
            };

            User user2 = new User()
            {
                userID = 2,
                userName = "Ben",
                password = "cafvavasv",
                email = "ben12@gmail.com",
                avatarURL = "https://lucidchart.zendesk.com/system/photos/0003/1037/4046/profile_image_4656145546_201415.png"
            };

            //----< Comments >-----------------
            Comment comment0 = new Comment()
            {
                commentID = 0,
                content = "Great. Thank you!",
                postTime = new DateTime(2019, 2, 6),
                status = true,
                author = user0,
                storyID = 0
            };

            Comment comment1 = new Comment()
            {
                commentID = 1,
                content = "Thanks for sharing. I love your story.",
                postTime = new DateTime(2019, 3, 6),
                status = true,
                author = user2,
                storyID = 0
            };

            Comment comment2 = new Comment()
            {
                commentID = 2,
                content = "Fantastic! These are great photos.",
                postTime = new DateTime(2019, 2, 6),
                status = true,
                author = user0,
                storyID = 1
            };

            Comment comment3 = new Comment()
            {
                commentID = 3,
                content = "That's a nice place. I hope I can go there in the future.",
                postTime = new DateTime(2019, 3, 6),
                status = true,
                author = user1,
                storyID = 1
            };

            Comment comment4 = new Comment()
            {
                commentID = 4,
                content = "What a beautiful duck!",
                postTime = new DateTime(2019, 3, 6),
                status = true,
                author = user2,
                storyID = 2
            };

            //----< Categories >-----------------
            Category ctg0 = new Category()
            {
                categoryID = 1,
                categoryName = "Sports"
            };

            Category ctg1 = new Category()
            {
                categoryID = 2,
                categoryName = "Animal"
            };

            //----< Stories >-----------------
            Story Story = new Story()
            {
                stroyID = 0,
                title = "Skating",
                content = "Skateboarding is an action sport which involves riding and performing tricks using a skateboard, " +
        "as well as a recreational activity, an art form, an entertainment industry job, and a method of transportation. --- Wikipedia",
                url = "https://images.pexels.com/photos/415188/pexels-photo-415188.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                createTime = new DateTime(2019, 1, 5),
                updateTime = new DateTime(2019, 2, 6),
                author = user0,
                status = true,
                category = ctg0,
                comments = new List<Comment>(){ 
                            comment0,
                            comment1
                        }
            };
            storys.Add(Story);

            Story = new Story()
            {
                stroyID = 1,
                title = "Person Horseback Riding Outdoors",
                content = "Today I went riding horse with friends in mcgraw NY. " +
                	"It was the best time of my life and we are going to make it a weekly thing. ",
                url = "https://images.pexels.com/photos/1524620/pexels-photo-1524620.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                createTime = new DateTime(2019, 1, 5),
                updateTime = new DateTime(2019, 2, 6),
                author = user1,
                status = true,
                category = ctg0,
                comments = new List<Comment>(){
                            comment2,
                            comment3
                        }
            };
            storys.Add(Story);

            Story = new Story()
            {
                stroyID = 2,
                title = "Mandarin Duck",
                content = "The mandarin, widely regarded as the world's most beautiful duck, is a native of China and Japan.",
                url = "https://nationalzoo.si.edu/scbi/migratorybirds/featured_photo/images/bigpic/mndu24.jpg",
                createTime = new DateTime(2019, 5, 1),
                updateTime = new DateTime(2019, 6, 3),
                author = user1,
                status = true,
                category = ctg1,
                comments = new List<Comment>(){
                            comment4
                        }
            };
            storys.Add(Story);

        }

            public static StoryList getInstance()
            {
                if (instance == null)
                {
                    instance = new StoryList();
                }
                return instance;
            }

            public int size()
            {
                return storys.Count;
            }

            public void add(Story crs)
            {
                storys.Add(crs);
            }

            public bool delete(int id)
            {
                if (0 <= id && id < size())
                {
                    storys.RemoveAt(id);
                    return true;
                }
                return false;
            }

            public Story this[int i]
            {
                get { return storys[i]; }
                set { storys[i] = value; }
            }

            public IEnumerator<Story> GetEnumerator()
            {
                return storys.GetEnumerator();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return storys.GetEnumerator();
            }
    }
}
