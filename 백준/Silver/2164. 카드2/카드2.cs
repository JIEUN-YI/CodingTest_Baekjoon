namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int.TryParse(Console.ReadLine(), out int count);
            
            Queue<int> queue = new Queue<int>(count);

            for(int i = 0; i < count; i++)
            {
                queue.Enqueue(i + 1);
            }

            while(queue.Count > 1)
            {
                queue.Dequeue(); // 맨 앞에 삭제
                queue.Enqueue(queue.Dequeue()); // 그 다음 수를 삭제 후 재 삽입
            }
            
            Console.WriteLine(queue.Peek());
        }
    }
}

