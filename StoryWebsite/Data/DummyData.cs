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

            Category ctg5 = new Category()
            {
                categoryName = "Technology"
            };


            //----< Users >---------------------------------------------------------------
            ApplicationUser user0 = new ApplicationUser()
            {
                fullName = "BJK",
                avatarURL = "https://lucidchart.zendesk.com/system/photos/8933/3314/profile_image_678269360_201415.png"
            };

            ApplicationUser user1 = new ApplicationUser()
            {
                fullName = "Jean van der Meulen",
                avatarURL = "https://lucidchart.zendesk.com/system/photos/0003/5071/8906/profile_image_252411440_201415.png"
            };

            ApplicationUser user2 = new ApplicationUser()
            {
                fullName = "Ben",
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
                author = user0
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

            StorySlide slide4 = new StorySlide()
            {
                title = "Dragonfly in Grass",
                description = "This is a dragonfly.",
                url = "https://images.pexels.com/photos/574059/pexels-photo-574059.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260"
            };

            StorySlide slide5 = new StorySlide()
            {
                title = "Model K Adder",
                description = "Called the “Model K” Adder because he built it on his “Kitchen” table, this simple demonstration circuit provides proof of concept for applying Boolean logic to the design of computers, resulting in construction of the relay-based Model I Complex Calculator in 1939. ",
                url = "https://images.computerhistory.org/timeline/timeline_computers_1937.modelk.jpg"
            };

            StorySlide slide6 = new StorySlide()
            {
                title = "Hewlett-Packard is founded",
                description = "David Packard and Bill Hewlett found their company in a Palo Alto, California garage. Their first product, the HP 200A Audio Oscillator, rapidly became a popular piece of test equipment for engineers.",
                url = "https://images.computerhistory.org/timeline/timeline_computers_1939.hewlettpackard.jpg"
            };

            StorySlide slide7 = new StorySlide()
            {
                title = "Konrad Zuse finishes the Z3 Computer",
                description = "The Z3, an early computer built by German engineer Konrad Zuse working in complete isolation from developments elsewhere, uses 2,300 relays, performs floating point binary arithmetic, and has a 22-bit word length.",
                url = "https://images.computerhistory.org/timeline/timeline_computers_1941.zusez3.jpg"
            };

            StorySlide slide8 = new StorySlide()
            {
                title = "The first Bombe is completed",
                description = "Built as an electro-mechanical means of decrypting Nazi ENIGMA-based military communications during World War II, the British Bombe is conceived of by computer pioneer Alan Turing and Harold Keen of the British Tabulating Machine Company. ",
                url = "https://images.computerhistory.org/timeline/timeline_computers_1941.bombe.jpg"
            };

            StorySlide slide9 = new StorySlide()
            {
                title = "Curt Herzstark designs Curta calculator",
                description = "Curt Herzstark was an Austrian engineer who worked in his family’s manufacturing business until he was arrested by the Nazis in 1943. While imprisoned at Buchenwald concentration camp for the rest of World War II, he refines his pre-war design of a calculator featuring a modified version of Leibniz’s “stepped drum” design.",
                url = "https://images.computerhistory.org/timeline/timeline_computers_1943.curta.jpg"
            };

            StorySlide slide10 = new StorySlide()
            {
                title = "Brown Horse On Grass Field",
                description = "This is a beautiful horse.",
                url = "https://images.pexels.com/photos/635499/pexels-photo-635499.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260"
            };

            StorySlide slide11 = new StorySlide()
            {
                title = "Girl Riding Black Horse",
                description = "This is a beautiful horse.",
                url = "https://images.pexels.com/photos/1364073/pexels-photo-1364073.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260"
            };

            StorySlide slide12 = new StorySlide()
            {
                title = "Woman Riding White Horse",
                description = "Woman Wearing Black Long-sleeved Blazer on White Horse",
                url = "https://images.pexels.com/photos/1125063/pexels-photo-1125063.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260"
            };

            StorySlide slide13 = new StorySlide()
            {
                title = "Person Riding on Horse",
                description = "Person Riding on Horse Under Cloudy Sky during Daytime",
                url = "https://images.pexels.com/photos/179990/pexels-photo-179990.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260"
            };

            StorySlide slide14 = new StorySlide()
            {
                title = "Man Skateboarding",
                description = "Man Skateboarding",
                url = "https://images.pexels.com/photos/415176/pexels-photo-415176.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260"
            };

            StorySlide slide15 = new StorySlide()
            {
                title = "Man Doing Tricks on a Skateboard",
                description = "Man Doing Tricks on a Skateboard",
                url = "https://images.pexels.com/photos/1984121/pexels-photo-1984121.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260"
            };

            StorySlide slide16 = new StorySlide()
            {
                title = "Man Doing A Skateboard Trick",
                description = "Man Doing A Skateboard Trick",
                url = "https://images.pexels.com/photos/1769553/pexels-photo-1769553.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260"
            };

            StorySlide slide17 = new StorySlide()
            {
                title = "Blue and Brown Duck",
                description = "Blue and Brown Duck",
                url = "https://images.pexels.com/photos/402556/pexels-photo-402556.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260"
            };

            StorySlide slide18 = new StorySlide()
            {
                title = "Mandarin Duck on Water",
                description = "Mandarin Duck on Water",
                url = "https://images.pexels.com/photos/416166/pexels-photo-416166.jpeg?auto=compress&cs=tinysrgb&dpr=2&h=750&w=1260"
            };



            //-------------------------< Stories >------------------------------------------
            var testStory = context.stories.FirstOrDefault(a => a.title == "Computer History");
            if (testStory == null)
            {
                var story = new Story()
                {
                    title = "Computer History",
                    content = "It is about computer history.",
                    url = "https://images.computerhistory.org/timeline/timeline_computers_1939.hewlettpackard.jpg",
                    createTime = new DateTime(2019, 5, 7),
                    updateTime = new DateTime(2019, 5, 7),
                    author = user1,
                    status = true,
                    category = ctg5,
                    comments = new List<Comment>(){
                            comment0
                        },
                    slides = new List<StorySlide>() {
                            slide5,
                            slide6,
                            slide7,
                            slide8,
                            slide9
                    }
                };
                context.stories.Add(story);
            }

            testStory = context.stories.FirstOrDefault(a => a.title == "Beautiful Beetles");
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
                            slide3,
                            slide4
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
                        },
                    slides = new List<StorySlide>() {
                            slide10,
                            slide11,
                            slide12,
                            slide13
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
                        },
                    slides = new List<StorySlide>() {
                            slide14,
                            slide15,
                            slide16
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
                        },
                    slides = new List<StorySlide>() {
                            slide17,
                            slide18
                    }
                };

                context.stories.Add(story);
            }

            context.SaveChanges();
        }
    }
}
