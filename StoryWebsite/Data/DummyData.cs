using StoryWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoryWebsite.Data
{
    public class DummyData
    {
        public static void Initialize(StoryWebsiteDbContext context)
        {
            context.Database.EnsureCreated();

            //----< Categories >------------------------------------------------------

            Category ctg1 = new Category()
            {
                categoryName = "Sports"
            };

            Category ctg2 = new Category()
            {
                categoryName = "Animal"
            };

            Category ctg3 = new Category()
            {
                categoryName = "Life"
            };

            Category ctg4 = new Category()
            {
                categoryName = "People"
            };


            //----< Users >---------------------------------------------------------------
            User user0 = new User()
            {
                userName = "Yilin Ren",
                password = "cxmnbxzmnkh",
                email = "yren20@syr.edu",
                avatarURL = "https://lucidchart.zendesk.com/system/photos/8933/3314/profile_image_678269360_201415.png"
            };

            User user1 = new User()
            {
                userName = "Jean van der Meulen",
                password = "a12mnsdfsafsa",
                email = "jvsm@gmail.com",
                avatarURL = "https://lucidchart.zendesk.com/system/photos/0003/5071/8906/profile_image_252411440_201415.png"
            };

            User user2 = new User()
            {
                userName = "Ben",
                password = "cafvavasv",
                email = "ben12@gmail.com",
                avatarURL = "https://lucidchart.zendesk.com/system/photos/0003/1037/4046/profile_image_4656145546_201415.png"
            };

            //----< Comments >-----------------
            Comment comment0 = new Comment()
            {
                content = "Great. Thank you!",
                postTime = new DateTime(2019, 2, 6),
                status = true,
                author = user0,
                //storyID = 0
            };

            Comment comment1 = new Comment()
            {
                content = "Thanks for sharing. I love your story.",
                postTime = new DateTime(2019, 3, 6),
                status = true,
                author = user2,
                //storyID = 0
            };

            Comment comment2 = new Comment()
            {
                content = "Fantastic! These are great photos.",
                postTime = new DateTime(2019, 2, 6),
                status = true,
                author = user0,
                //storyID = 1
            };

            Comment comment3 = new Comment()
            {
                content = "That's a nice place. I hope I can go there in the future.",
                postTime = new DateTime(2019, 3, 6),
                status = true,
                author = user1
            };

            Comment comment4 = new Comment()
            {
                content = "What a beautiful duck!",
                postTime = new DateTime(2019, 3, 6),
                status = true,
                author = user2
            };

            //-------------------------< Story Slides >------------------------------------------
            StorySlide slide1 = new StorySlide()
            {
                title = "Ladybug",
                description = "A red and black ladybug in morning dew.",
                url = "https://images.pexels.com/photos/33544/ladybug-beetle-insect-lucky-charm.jpg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260"
            };

            StorySlide slide2 = new StorySlide()
            {
                title = "Yellow and Black Ladybug",
                description = "A yellow and black ladybug in morning dew.",
                url = "https://images.pexels.com/photos/33057/beetles-harmonia-axyridis-ladybug.jpg?cs=srgb&dl=axyridis-beetle-drops-33057.jpg&fm=jpg"
            };

            StorySlide slide3 = new StorySlide()
            {
                title = "A Bee",
                description = "Bees are collecting honey. The process by which honeybees collect nectar from plants to make honey demonstrates a fascinating combination of science and nature at work.",
                url = "https://images.pexels.com/photos/211467/pexels-photo-211467.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260"
            };


            //-------------------------< Stories >------------------------------------------
            var testStory = context.stories.FirstOrDefault(a => a.title == "Beautiful Beetles");
            if (testStory == null)
            {
                var story = new Story()
                {
                    title = "Beautiful Beetles",
                    content = "Today I went riding horse with friends in mcgraw NY. ",
                    url = "https://images.pexels.com/photos/33544/ladybug-beetle-insect-lucky-charm.jpg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                    createTime = new DateTime(2019, 1, 5),
                    updateTime = new DateTime(2019, 2, 6),
                    author = user1,
                    status = true,
                    category = ctg2,
                    comments = new List<Comment>(){
                            comment0
                        },
                    slides = new List<StorySlide>() {
                            slide1,
                            slide2,
                            slide3
                    }
                };

                context.stories.Add(story);
            }

            testStory = context.stories.FirstOrDefault(a => a.title == "Person Horseback Riding Outdoors");
            if (testStory == null)
            {
                var story = new Story()
                {
                    title = "Person Horseback Riding Outdoors",
                    content = "Today I went riding horse with friends in mcgraw NY. " +
                        "It was the best time of my life and we are going to make it a weekly thing. ",
                    url = "https://images.pexels.com/photos/1524620/pexels-photo-1524620.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                    createTime = new DateTime(2019, 1, 5),
                    updateTime = new DateTime(2019, 2, 6),
                    author = user1,
                    status = true,
                    category = ctg1,
                    comments = new List<Comment>(){
                            comment0
                        }
                };

                context.stories.Add(story);
            }

            testStory = context.stories.FirstOrDefault(a => a.title == "Skating");
            if (testStory == null)
            {
                Story story = new Story()
                {
                    title = "Skating",
                    content = "Skateboarding is an action sport which involves riding and performing tricks using a skateboard, " +
"as well as a recreational activity, an art form, an entertainment industry job, and a method of transportation. --- Wikipedia",
                    url = "https://images.pexels.com/photos/415188/pexels-photo-415188.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260",
                    createTime = new DateTime(2019, 1, 5),
                    updateTime = new DateTime(2019, 2, 6),
                    author = user0,
                    status = true,
                    category = ctg1,
                    comments = new List<Comment>(){
                            comment0,
                            comment1
                        }
                };

                context.stories.Add(story);
            }

            testStory = context.stories.FirstOrDefault(a => a.title == "Mandarin Duck");
            if (testStory == null)
            {
                var story = new Story()
                {
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

                context.stories.Add(story);
            }

            context.SaveChanges();
        }
    }
}
