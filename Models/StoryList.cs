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
            User user0 = new User()
            {
                userID = 1,
                userName = "Yilin Ren",
                password = "cxmnbxzmnkh",
                email = "yren20@syr.edu"
            };

            User user1 = new User()
            {
                userID = 2,
                userName = "Jean van der Meulen",
                password = "a12mnsdfsafsa",
                email = "jvsm@gmail.com"
            };

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
                category = ctg0

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
                category = ctg0
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
                category = ctg1
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
