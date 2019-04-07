using System;
using System.Collections;
using System.Collections.Generic;

namespace MvcSkeleton.Models
{
    public class LabList : IEnumerable<Lab>
    {
        public List<Lab> Labs { get; set; } = new List<Lab>();

        private static LabList instance { get; set; } = null;  // holds persistant instance

        private LabList() 
        {
            Lab lab = new Lab()
            {
                id = 101,
                number = 1,
                target = "This lab focuses on setting up programming environments for the labs and projects.",
                topic = "Programming Environments",
                due = new DateTime(2019, 2, 1)
            };
            Labs.Add(lab);
            lab = new Lab()
            {
                id = 102,
                number = 2,
                target = "This lab focuses on building static web pages, using HTML5, CSS3, and EC6 (latest version of JavaScript)." +
                	" You will use all three to define a theme for your web pages.",
                topic = "Static Web Pages",
                due = new DateTime(2019, 2, 8)
            };
            Labs.Add(lab);
            lab = new Lab()
            {
                id = 103,
                number = 3,
                target = "This lab focuses on the use of Cascading Style Sheets (CSS) to build a useful component for your web pages.",
                topic = "CSS Styling Lab",
                due = new DateTime(2019, 2, 15)
            };
            Labs.Add(lab);
        }

        public static LabList getInstance()
        {
            if (instance == null)
            {
                instance = new LabList();
            }
            return instance;
        }

        public int size()
        {
            return Labs.Count;
        }

        public void add(Lab crs)
        {
            Labs.Add(crs);
        }

        public bool delete(int id)
        {
            if (0 <= id && id < size())
            {
                Labs.RemoveAt(id);
                return true;
            }
            return false;
        }

        public Lab this[int i]
        {
            get { return Labs[i]; }
            set { Labs[i] = value; }
        }

        public IEnumerator<Lab> GetEnumerator()
        {
            return Labs.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
