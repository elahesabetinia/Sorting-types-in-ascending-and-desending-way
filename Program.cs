using SortingLibrary;
using Figgle;

class Program
{
    static void Main()
    {
        string title = """Welcome ! """;
        string divider = new string('.', title.Length);

        // نمایش عنوان با انیمیشن
        AnimateText.Animate(FiggleFonts.Standard.Render(title), 1);
        AnimateText.Animate(divider, 1);

        // نمایش نام الگوریتم‌ها
        AnimateText.Animate("we have 4 way for sorting and 2 way for implrmrntation , here ! let me show you : ", 45);
        AnimateText.Animate("1. Bubble Sort", 100);
        AnimateText.Animate("2. Merge Sort", 100);
        AnimateText.Animate("3. Selection Sort", 100);
        AnimateText.Animate("4. Insertion Sort", 100);

        // ایجاد آرایه نمونه
        int[] array = { 5, 2, 9, 1, 5, 6 };

        // اجرای مرتب‌سازی
        Sorter.RunSorts(array);

        // استفاده از افکت رنگی
        Console.ForegroundColor = ConsoleColor.Cyan;
        AnimateText.Animate("Sorting Complete! :)");
        Console.ResetColor();
    }
}
