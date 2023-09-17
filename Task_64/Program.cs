Console.Write("Enter N = ");
int n = Convert.ToInt32(Console.ReadLine());
//int i = 0;
method(n);
int method(int n){
    Console.Write(n + " ");
    if(n == 1){
        Console.WriteLine("");
        Console.WriteLine("End");
        return 0;
    }else{
        return method(n - 1);
    }
}