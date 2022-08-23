//Урок 7. Рекурсия.
//Самое важное при описании рекурсии -- обозначить условия выхода из нее. 
/*
string NumbersRec(int a, int b)
{
    if (a <= b) return $"{a} " + NumbersRec(a+1, b);
    else return String.Empty; //условие выхода
}

Console.WriteLine(NumbersRec(1, 10));

int SumRec(int n)
{
    if (n == 0) return 0;
    else return n + SumRec(n - 1);
}

Console.WriteLine(SumRec(10));

int FactorialRec(int n)
{
    if (n == 1 || n == 0) return 1;
    else return n * FactorialRec(n-1);
}

Console.WriteLine(FactorialRec(3));

int ValueToThePower(int a, int n)
{
    if (n == 0) return 1;
    else return ValueToThePower(a, n - 1) * a;
}

Console.WriteLine(ValueToThePower(2, 3));


string path = "C:/Users/п/Downloads";
DirectoryInfo di = new DirectoryInfo(path);
System.Console.WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles();

for (int i = 0; i < fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name);
}

void CatalogInfo(string path, string indent = "")
{
    DirectoryInfo catalog = new DirectoryInfo(path);
    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + " ");
    }

    FileInfo[] files = catalog.GetFiles();
    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{indent}{files[i].Name}");
    }
}

string path = "C:/Users/п/Downloads";
CatalogInfo(path);


//Игра в башенки.

void Towers(string with = "1", string on = "3", string some = "2", int count = 3)
{
 if (count > 1) Towers(with, some, on, count - 1);
 Console.WriteLine($"{with} >> {on}");
 if (count > 1) Towers(some, on, with, count - 1);
}
*/

//Деревья.
string emp = String.Empty;
string[] tree = { emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };

void InOrderTraversal(int pos = 1)
{
    if (pos < tree.Length)
    {
    int left = 2 * pos;
    int right = 2 * pos + 1;
    if (left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTraversal(left);
    Console.WriteLine(tree[pos]);
    if (right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTraversal(right);
    }
}
InOrderTraversal();