using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace wpfquiz1
{
    public class Node
    {
        internal int questionnumber = 0;
        internal String question = String.Empty;
        internal String optionA = String.Empty;
        internal String optionB = String.Empty;
        internal String optionC = String.Empty;
        internal String optionD = String.Empty;
        internal String answer = String.Empty;
        internal String imgpath = String.Empty;
        internal String category = String.Empty;
        internal Boolean asked = false;
        internal Node next = null;
        public Node()
        {

        }
    }

    public class linklistop
    {
        public Node head;
        Random random = new Random();
        String dir;

        public linklistop()
        {
            head = null;
        }
        public void Insert(int qnum, String q, String opA, String opB, String opC, String opD, String ans, String path, String cat)
        {
            Node ptr = new Node();
            ptr.questionnumber = qnum;
            ptr.question = q;
            ptr.optionA = opA;
            ptr.optionB = opB;
            ptr.optionC = opC;
            ptr.optionD = opD;
            ptr.answer = ans;
            ptr.imgpath = path;
            if (head == null)
            {
                head = ptr;
            }
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    if (temp.next == null)
                    {
                        temp.next = ptr;
                        temp = null;
                    }
                    else
                    {
                        temp = temp.next;
                    }
                }
            }
        }
        public void fillthelinklist(String directory, String categ)
        {
            dir = directory;
            StreamWriter sws = new StreamWriter(directory + "\\" + categ + "\\haha.txt", true, Encoding.ASCII);
            sws.Write(String.Empty);
            sws.Close();
            foreach (string line in File.ReadLines(directory + "\\" + categ + "\\Questions.txt", Encoding.UTF8))
            {
                string questionnumber = String.Empty;
                string question = String.Empty;
                string optionA = String.Empty;
                string optionB = String.Empty;
                string optionC = String.Empty;
                string optionD = String.Empty;
                string answer = String.Empty;
                String imagepath = String.Empty;
                int i;
                for (i = 2; i < line.Length; i++)
                {
                    if (line[i] != '*')
                    {
                        questionnumber = questionnumber + line[i];
                    }
                    else
                    {
                        break;
                    }
                }
                for (int j = i + 1; j < line.Length; j++)
                {
                    if (line[j] != ':')
                    {
                        question = question + line[j];
                    }
                    else
                    {
                        i = j + 1;
                        break;
                    }
                }
                for (int j = i; j < line.Length; j++)
                {
                    if (line[j] != '@')
                    {
                        optionA = optionA + line[j];
                    }
                    else
                    {
                        i = j + 1;
                        break;
                    }
                }
                for (int j = i; j < line.Length; j++)
                {
                    if (line[j] != '@')
                    {
                        optionB = optionB + line[j];
                    }
                    else
                    {
                        i = j + 1;
                        break;
                    }
                }
                for (int j = i; j < line.Length; j++)
                {
                    if (line[j] != '@')
                    {
                        optionC = optionC + line[j];
                    }
                    else
                    {
                        i = j + 1;
                        break;
                    }
                }
                for (int j = i; j < line.Length; j++)
                {
                    if (line[j] != '/')
                    {
                        optionD = optionD + line[j];
                    }
                    else
                    {
                        i = j + 1;
                        break;
                    }
                }
                for (int j = i; j < line.Length; j++)
                {
                    answer = answer + line[j];
                }
                String filedir = directory + "\\" + categ + "\\" + questionnumber + ".jpg";
                if (File.Exists(filedir))
                {
                    imagepath = filedir;
                }
                Insert(Int32.Parse(questionnumber), question, optionA, optionB, optionC, optionD, answer, imagepath, categ);
            }
        }
        public void fillround2(String directory)
        {
            StreamWriter sws = new StreamWriter(directory + "\\" + "\\haha.txt", true, Encoding.ASCII);
            sws.Write(String.Empty);
            sws.Close();
            foreach (string line in File.ReadLines(directory + "\\" + "Round2" + "\\Round2.txt", Encoding.UTF8))
            {
                string questionnumber = String.Empty;
                string question = String.Empty;
                string optionA = String.Empty;
                string optionB = String.Empty;
                string optionC = String.Empty;
                string optionD = String.Empty;
                string answer = String.Empty;
                String imagepath = String.Empty;
                int i;
                for (i = 2; i < line.Length; i++)
                {
                    if (line[i] != '*')
                    {
                        questionnumber = questionnumber + line[i];
                    }
                    else
                    {
                        break;
                    }
                }
                for (int j = i + 1; j < line.Length; j++)
                {
                    if (line[j] != ':')
                    {
                        question = question + line[j];
                    }
                    else
                    {
                        i = j + 1;
                        break;
                    }
                }
                for (int j = i; j < line.Length; j++)
                {
                    if (line[j] != '@')
                    {
                        optionA = optionA + line[j];
                    }
                    else
                    {
                        i = j + 1;
                        break;
                    }
                }
                for (int j = i; j < line.Length; j++)
                {
                    if (line[j] != '@')
                    {
                        optionB = optionB + line[j];
                    }
                    else
                    {
                        i = j + 1;
                        break;
                    }
                }
                for (int j = i; j < line.Length; j++)
                {
                    if (line[j] != '@')
                    {
                        optionC = optionC + line[j];
                    }
                    else
                    {
                        i = j + 1;
                        break;
                    }
                }
                for (int j = i; j < line.Length; j++)
                {
                    if (line[j] != '/')
                    {
                        optionD = optionD + line[j];
                    }
                    else
                    {
                        i = j + 1;
                        break;
                    }
                }
                for (int j = i; j < line.Length; j++)
                {
                    answer = answer + line[j];
                }
                String filedir = directory + "\\" + "Round2" + "\\" + questionnumber + ".jpg";
                if (File.Exists(filedir))
                {
                    imagepath = filedir;
                }
                else
                {
                    filedir = directory + "\\" + "Round2" + "\\" + questionnumber + ".png";
                    if (File.Exists(filedir))
                    {
                        imagepath = filedir;
                    }
                }
                Insert(Int32.Parse(questionnumber), question, optionA, optionB, optionC, optionD, answer, imagepath, "Gen");
            }
        }
        public void show()
        {
            Node temp = head;
            while (temp != null)
            {
                temp = temp.next;
            }
        }
        public Node returnquestionround1(Node ptr)
        {
            Node temp = head;
            int i = 0;
            while (temp != null)
            {
                i++;
                temp = temp.next;
            }
            temp = head;
            Boolean con = false;
            while (con == false)
            {
                int randquestion = random.Next(i + 1);
                if (randquestion == 0)
                {
                    con = false;
                }
                else
                {
                    temp = head;
                    Node t2 = head;
                    while (t2 != null)
                    {
                        if (t2.asked == false)
                        {
                            break;
                        }
                        else
                        {
                            t2 = t2.next;
                        }
                    }
                    if (t2 == null)
                    {
                        ptr = head;
                        ptr = null;
                        return ptr;
                    }
                    while (temp != null)
                    {
                        if (temp.questionnumber == randquestion && temp.asked == false)
                        {
                            //Boolean questionasked = questionalreadyasked(temp.question, temp.questionnumber);
                            //if (questionasked == true)
                            //{
                            //    temp = temp;
                            //    con = false;
                            //    break;
                            //}
                            //else
                            //{
                            //writequestiontofile(temp.question, temp.questionnumber);
                            ptr.questionnumber = temp.questionnumber;
                            ptr.question = temp.question;
                            ptr.optionA = temp.optionA;
                            ptr.optionB = temp.optionB;
                            ptr.optionC = temp.optionC;
                            ptr.optionD = temp.optionD;
                            ptr.answer = temp.answer;
                            ptr.imgpath = temp.imgpath;
                            ptr.category = temp.category;
                            temp.asked = true;
                            //show();
                            con = true;
                            return ptr;
                        }
                        //}
                        else if (temp.questionnumber == randquestion && temp.asked == true)
                        {
                            con = false;
                            break;
                        }
                        else
                        {
                            temp = temp.next;
                        }
                    }
                    if (temp == null)
                    {
                        con = false;
                    }
                }
            }
            return null;
        }
        public Node returnquestionround2(Node ptr)
        {
            Node temp = head;
            int i = 0;
            while (temp != null)
            {
                i++;
                temp = temp.next;
            }
            Boolean con = false;
            while (con == false)
            {
                int randquestion = random.Next(i + 1);
                if (randquestion == 0)
                {
                    con = false;
                }
                else
                {
                    temp = head;
                    Node t2 = head;
                    while (t2 != null)
                    {
                        if (t2.asked == false)
                        {
                            break;
                        }
                        else
                        {
                            t2 = t2.next;
                        }
                    }
                    if (t2 == null)
                    {
                        ptr = head;
                        ptr = null;
                        return ptr;
                    }
                    while (temp != null)
                    {
                        if (temp.questionnumber == randquestion && temp.asked == false)
                        {
                            ptr.questionnumber = temp.questionnumber;
                            ptr.question = temp.question;
                            ptr.optionA = temp.optionA;
                            ptr.optionB = temp.optionB;
                            ptr.optionC = temp.optionC;
                            ptr.optionD = temp.optionD;
                            ptr.answer = temp.answer;
                            ptr.imgpath = temp.imgpath;
                            ptr.category = temp.category;
                            temp.asked = true;
                            con = true;
                            return ptr;
                        }
                        else if (temp.questionnumber == randquestion && temp.asked == true)
                        {
                            con = false;
                            temp = null;
                        }
                        else
                        {
                            temp = temp.next;
                        }
                    }
                    if (temp == null)
                    {
                        con = false;
                    }

                }
            }
            return null;
        }
        //public void writequestiontofile(String writequestion, int questionnumber)
        //{
        //    StreamWriter sws = new StreamWriter("C: \\Users\\Salman Ahmad\\Documents\\QuizSukhan\\qts.txt", true, Encoding.ASCII);
        //    sws.Write(questionnumber.ToString()+"-->"+writequestion);
        //    sws.Close();
        //}
        //public Boolean questionalreadyasked(String writequestion, int questionnumber)
        //{
        //    foreach (string line in File.ReadLines("C: \\Users\\Salman Ahmad\\Documents\\QuizSukhan\\qts.txt", Encoding.UTF8))
        //    {
        //        String qt=questionnumber.ToString()+ "-->" + writequestion;
        //        if (line == qt)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}
    }
}
