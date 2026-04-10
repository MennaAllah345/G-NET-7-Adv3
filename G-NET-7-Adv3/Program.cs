using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_7_Adv03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1: Student Grade Manager
            //List<int> grades = new List<int> { 85, 92, 78, 95, 88, 70, 100, 65 };

            //// Print
            //Console.WriteLine("Grades:");
            //foreach (var g in grades)
            //    Console.Write(g + " ");

            //Console.WriteLine("\nCount: " + grades.Count);
            //Console.WriteLine("First: " + grades.First());
            //Console.WriteLine("Last: " + grades.Last());

            //// Sort
            //grades.Sort();
            //Console.WriteLine("\nSorted:");
            //grades.ForEach(g => Console.Write(g + " "));

            //// First > 90
            //Console.WriteLine("\nFirst > 90: " + grades.First(g => g > 90));

            //// < 75
            //var failing = grades.Where(g => g < 75).ToList();
            //Console.WriteLine("Failing:");
            //failing.ForEach(g => Console.Write(g + " "));

            //// Remove < 75
            //grades.RemoveAll(g => g < 75);
            //Console.WriteLine("\nAfter removing failing:");
            //grades.ForEach(g => Console.Write(g + " "));

            //// Check 100
            //Console.WriteLine("\nContains 100? " + grades.Contains(100));

            //// Transform
            //var gradeStrings = grades.Select(g => $"Grade: {g}").ToList();
            //Console.WriteLine("Strings:");
            //gradeStrings.ForEach(Console.WriteLine);
            #endregion

            #region Exercise 2: Leaderboard
            //    Console.WriteLine("\n--- Leaderboard ---");

            //    SortedDictionary<int, string> leaderboard = new SortedDictionary<int, string>()
            //{
            //    {500, "Ahmed"},
            //    {200, "Sara"},
            //    {800, "Ali"},
            //    {350, "Mona"}
            //};

            //    foreach (var item in leaderboard)
            //        Console.WriteLine($"{item.Key} = {item.Value}");

            //    Console.WriteLine("First Key: " + leaderboard.First().Key);
            //    Console.WriteLine("First Value: " + leaderboard.First().Value);

            //    Console.WriteLine("Contains 500? " + leaderboard.ContainsKey(500));

            //    // Safe get
            //    if (leaderboard.TryGetValue(999, out string player))
            //        Console.WriteLine(player);
            //    else
            //        Console.WriteLine("Not found");

            //    // Remove
            //    leaderboard.Remove(200);
            //    Console.WriteLine("After remove:");
            //    foreach (var item in leaderboard)
            //        Console.WriteLine($"{item.Key} = {item.Value}");
            #endregion

            #region Exercise 3: Phone Book
            //    Console.WriteLine("\n--- Phone Book ---");

            //    Dictionary<string, string> phoneBook = new Dictionary<string, string>()
            //{
            //    {"Ahmed", "111"},
            //    {"Sara", "222"},
            //    {"Ali", "333"},
            //    {"Mona", "444"}
            //};

            //    // [] add/update
            //    phoneBook["Ahmed"] = "999";

            //    // Add duplicate
            //    try
            //    {
            //        phoneBook.Add("Ahmed", "000");
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine("Error: " + ex.Message);
            //    }

            //    // TryAdd
            //    bool added = phoneBook.TryAdd("Ahmed", "555");
            //    Console.WriteLine("TryAdd success? " + added);

            //    // Search not exist
            //    Console.WriteLine("Contains John? " + phoneBook.ContainsKey("John"));

            //    // Fallback
            //    Console.WriteLine(NewMethod());

            //    // Keys
            //    Console.WriteLine("Keys:");
            //    foreach (var k in phoneBook.Keys)
            //        Console.Write(k + " ");

            //    Console.WriteLine("\nValues:");
            //    foreach (var v in phoneBook.Values)
            //        Console.Write(v + " ");

            //    object NewMethod()
            //    {
            //        return phoneBook.GetValueOrDefault("John", "Not Found");
            //    }
            #endregion

            #region Exercise 4: Unique Email Validator
            //    Console.WriteLine("\n--- HashSet ---");

            //    HashSet<string> emails = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            //{
            //    "ahmed@test.com",
            //    "AHMED@test.com",
            //    "sara@test.com",
            //    "Sara@Test.Com"
            //};

            //    Console.WriteLine("Count: " + emails.Count);
            //    // هيبقى 2 لأن IgnoreCase

            //    HashSet<int> A = new HashSet<int> { 1, 2, 3, 4, 5 };
            //    HashSet<int> B = new HashSet<int> { 4, 5, 6, 7, 8 };

            //    var union = new HashSet<int>(A);
            //    union.UnionWith(B);
            //    Console.WriteLine("Union: " + string.Join(",", union));

            //    var intersect = new HashSet<int>(A);
            //    intersect.IntersectWith(B);
            //    Console.WriteLine("Intersect: " + string.Join(",", intersect));

            //    var except = new HashSet<int>(A);
            //    except.ExceptWith(B);
            //    Console.WriteLine("Except: " + string.Join(",", except));

            //    Console.WriteLine("IsSubset: " + new HashSet<int> { 1, 2 }.IsSubsetOf(A));
            #endregion

            #region Exercise 5: Print Queue Simulator
            //Console.WriteLine("\n--- Queue ---");

            //Queue<string> queue = new Queue<string>();
            //queue.Enqueue("Report.pdf");
            //queue.Enqueue("Invoice.pdf");
            //queue.Enqueue("Letter.docx");
            //queue.Enqueue("Resume.pdf");
            //queue.Enqueue("Photo.jpg");

            //Console.WriteLine("Queue:");
            //foreach (var q in queue)
            //    Console.WriteLine(q);

            //Console.WriteLine("Count: " + queue.Count);
            //Console.WriteLine("Next: " + queue.Peek());

            //while (queue.Count > 0)
            //{
            //    Console.WriteLine("Printing: " + queue.Dequeue());
            //}

            //bool success = queue.TryDequeue(out string doc);
            //Console.WriteLine("TryDequeue success? " + success);
            #endregion

            #region Exercise 6: Browser History (Undo)

            //Console.WriteLine("\n--- Stack ---");

            //Stack<string> history = new Stack<string>();

            //history.Push("google.com");
            //history.Push("github.com");
            //history.Push("stackoverflow.com");
            //history.Push("youtube.com");
            //history.Push("claude.ai");

            //Console.WriteLine("Current: " + history.Peek());

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("Back from: " + history.Pop());
            //}

            //Console.WriteLine("Current after back: " + history.Peek());

            //history.Clear();
            //bool popped = history.TryPop(out string page);
            //Console.WriteLine("TryPop success? " + popped);
            #endregion


        }
    }
}
