namespace اكواد_السيشن
{
    internal class Program
    {


        #region function(method)
        #region Ex1

        ////static void CalculateAverage(int[] num) // void معناها مش هيرجع حاجه
        ////بعدين اديها الباراميتار اللي هي الحاجه اللي عيزاها عشان تشتغل وهنا هتكون اراي function دي وبدين ادي اسم  static voidبكتب
        ////بفتح بقا قوس مجموعه واحط الحاجه بتعتي
        //static void CalculateAverage1(int[] num)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < num.Length; i++)
        //    {
        //        sum += num[i];
        //    }
        //    int ava = sum / num.Length;
        //    Console.WriteLine("avarage = " + ava);
        //}

        #endregion

        #region EX2
        //// عايز اطبع حاجه عدد عين
        //static void print()
        //{
        //    for (int i = 0; i < 10; i++)

        //        Console.WriteLine("*");
        //}
        //// كده الفنكشن خلصت انادي بقا عليها

        #endregion

        #region EX3
        // هو لازم كل مره اطبع * مبنفعش اغيرها ؟ ااه ينفع اني هبعت معاها براميتار
        //ولما اجي انادي اديها الحاجه اللي عايزها تطبع
        //static void printpattern ( string pattern)
        //{
        //    for (int i = 0; i < 10; i++)

        //        Console.WriteLine(pattern);
        //}
        //// كده الفنكشن خلصت انادي بقا عليها

        #endregion

        #region EX4
        //طب لاوم التزم بالعد كل مره ولا ينفع انا ادخله برضو ؟ لاينفع هديها براميتار للعد وابق  انادي عليه
        //static void printpattern(string pattern , int count)
        //{
        //    for (int i = 0; i < count; i++)// هتلف ع اد ما هدخلك

        //        Console.WriteLine(pattern);
        //}
        //// كده الفنكشن خلصت انادي بقا عليها

        #endregion

        #region EX5 
        //بحيث ان لو اليوزر مدخلش حاجه ادخله انا defult value  طب انا عايز احط
        // static void printpattern(string pattern, int count)
        // {
        //     for (int i = 0; i < count; i++)// هتلف ع اد ما هدخلك

        //         Console.WriteLine(pattern);
        // }
        //// كده الفنكشن خلصت
        ////defult value هعمل واحده لل
        // static void printpatterndefult(string pattern = "*", int count = 10)
        // // ده defult لو اليوزر دخل حاج غير دول خد بتوع اليوزر لو مدخلش حاجه منهم خد ال
        // //body هحط نفس ال 
        // {
        //     for (int i = 0; i<count; i++)// هتلف ع اد ما هدخلك

        //         Console.WriteLine(pattern);
        // }
        // //انادي بقا عليها
        #endregion

        #endregion

        #region value type parametar
        //by reference ولا  by value هشوف بقا انا هبعته  value type النوع عندي 

        #region pass by value
        //  في العمليات التي تعتمد فقط على قراءة القيم، مثل الحسابات أو طباعة البيانات.زي جمع رقمين
        //  أي تغييرات تُجرى على البارامتر داخل الدالة لا تؤثر على المتغير الأصلي.

        #region ex swap
        //static void swap(int x, int y)
        //{
        //  int temp = x;
        //  x = y;
        //  y = temp;
        //}
        #endregion

        #endregion

        #region pass by refrence
        // تبديل قيمتين،
        //إذا كانت الدالة تحتاج إلى إرجاع أكثر من نتيجة واحد
        //object , array , swap  ذا كانت البيانات كبيرة مثل  

        #region ex swap
        //pass by refrence يحصل محتاج اعمل  swap عشان ال 

        //static void swap(ref int x, ref int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}
        #endregion

        #endregion

        #endregion

        #region refernce type parametar
        //by reference ولا  by value هشوف بقا انا هبعته  refernce type النوع عندي 
        //ف معنديش مشكله استخدم دي او دي array  طالما انا بغير ف عنصر جوا ال
        //عشان التغيير يسمع pass by refernceنفسها مش ف العناصر اللي فيها مثلا هعنل اوبجكت جديد واحط قيم فيه استخدم  array لو هعلب ف ال

        #region pass by value
        //  في العمليات التي تعتمد فقط على قراءة القيم، مثل الحسابات أو طباعة البيانات.زي جمع رقمين
        //  أي تغييرات تُجرى على البارامتر داخل الدالة لا تؤثر على المتغير الأصلي.

        #region ex sumarray
        //عايز القيم اللي جواها هعمل عليها عمليه وبس by value بس انا هبعتها refrenceانا هعمل اراي وطبعا عارف ان الاراي د نوعها
        //public static int sumarray(int[] arr)
        //{
        //    //arr[0] = 100;
        //    int sum = 0;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        sum += arr[i];
        //    }
        //    return sum;
        //}

        #endregion

        #endregion

        #region pass by refrence
        // تبديل قيمتين،
        //إذا كانت الدالة تحتاج إلى إرجاع أكثر من نتيجة واحد
        //object , array , swap  ذا كانت البيانات كبيرة مثل  

        #region ex sumarray
        //// by refrence بس انا هبعتها refrenceانا هعمل اراي وطبعا عارف ان الاراي د نوعها
        //public static int sumarray(ref int[] arr)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        sum += arr[i];
        //    }
        //    return sum;
        //}

        #endregion

        #region ex sumarray معدل
        // by refrence بس انا هبعتها refrenceانا هعمل اراي وطبعا عارف ان الاراي د نوعها
        //public static int sumarray(ref int[] arr)
        //{
        //    int sum = 0;
        //    arr = new int[] { 4, 5, 6 };// غيرت ف الاراي مهما احط اي حاجه تحت مش هتسمع
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        sum += arr[i];
        //    }
        //    return sum;
        //}

        #endregion

        #endregion

        #endregion

        #region pssing by out
        // واحده بس مينفعش تعمل كذا حاجه مع بعض task بتعمل  functionمعروف ان ال
        //pssing by outلاكتر من حاجه باستخدامreturn انا هعمل 
        //static int SumMul(int x, int y)
        //{
        //    int sum = 0;
        //    int mul = 0;
        //    return sum;
        //    return mul;// دي مش متشافه عند وباهته ومش هتم طب احل المشكله ازاي ؟؟
        //}
        //pssing by out باستخدام
        //=================================
        //static void SumMul(int x, int y , out int sum , out int mul) //هعرفهم ف البرامتار اني هاخد قيمتهم 
        //{
        //    //هخزن بقا اللي هيطلع هنا
        //     sum = x+y;
        //     mul = x*y;
        //}
        #endregion

        #region params >> direct بتعتي value هبعت ال
        // معناها اني بنادي ع الفنكشن وببعتلها القيم بتعتي علي طول منغير مثا م اخليها تاخدها من اراي
        //params لازم ونا بعرفها احط كلمه
        //public static int sumarray(params int[] arr)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        sum += arr[i];
        //    }
        //    return sum;
        //}
        #endregion


        #region Exception Handlin And Pritective Code
        // Exception >> بتظهرلي ف مرحله الرن لما اعمل حاجه غلط ف الكود 
        //FormatException هيديني int بدل  string مثلا انا دخلت 
        //DivideByZeroException مثلا انا قسمت علي صفر هيديني
        //IndexOutOfRangeException مثلا عندي اراي وعايز اجيب رقم خارج حدود الاراي دي هيديني
        // ف انا لازم اهندل الدنيا دي م البدابه عندي

        //static void DoSomeCode()
        //{
        //    int x, y, z;
        //    Console.WriteLine("please enter x ");
        //    x = int.Parse(Console.ReadLine());
        //    Console.WriteLine("please enter y ");
        //    y = int.Parse(Console.ReadLine());
        //    z = x / y;

        //    int[] num = { 1, 2, 3 };
        //    num[100] = 10;

        //لا انا هعمل  exception طب هو انا بقا هحفظ كل ال 
        //ولما يلاقي اكسبشن يطبعلي المسدج بتاع الاكسبشن دا try catch
        #region try catch
        //try:exception يحتوي على الكود الذي يمكن أن يُسبب .
        //catch:exception يتم تنفيذ هذا الجزء إذا حدث .
        //وتطلع برا الكود كلو Message ف اي حته بتطلع ال exception من عيوبها انها لو لقت
        //static void DoSomeCode()
        //{
        //    try
        //    {
        //        int x, y, z;
        //        Console.WriteLine("please enter x ");
        //        x = int.Parse(Console.ReadLine());
        //        Console.WriteLine("please enter y ");
        //        y = int.Parse(Console.ReadLine());
        //        z = x / y;

        //        int[] num = { 1, 2, 3 };
        //        num[100] = 10;
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }

        //    //م الاول protective code طب مهو مش صح اني اعمل كده انا ازك اكتب 
        //}
        #endregion


        #endregion

        #region Pritective Code
        //م الاول protective code طب مهو مش صح اني اعمل كده انا ازك اكتب 
        //static void DoSomeCode()
        //{
        //    int x, y, z;
        //    bool flag;
        //    do
        //    {
        //        Console.WriteLine("please enter x ");
        //        flag = int.TryParse(Console.ReadLine(), out x);

        //    } while (!flag);

        //    do
        //    {
        //        Console.WriteLine("please enter y ");
        //        flag = int.TryParse(Console.ReadLine(), out y);

        //    } while (!flag || y == 0);//ب 0 خش جوا اللوب تاني y طول م ال

        //    z = x / y;
        //    // هنا انا عايز اتاكد ان الرقك اكبر من 100 عشان يعمل الحوار دا لو كان اكبر هيعمل مش اكبر خلاص
        //    int[] num = { 1, 2, 3 };
        //    if (num?.Length > 100)
        //    {
        //        num[100] = 10;
        //    }
        //    else
        //    {
        //        Console.WriteLine("array out of range");
        //    }

        //}
            #endregion


        static void Main(string[] args)
        {

            #region function(method)

            #region التعريف
            //دي بتساعدني اني اقسم الكود بتاعي لمجموعه وظايف صغيره كل وظيفه بتعمل حاجه
            //سهةله الصيانه ان لو عندي مشكله ف حته معينه اقدر اعرف فين المشكله منغير ما اعدي ع الكود كلو maintainability
            //بتنظملي الكود و بتخليني امنع التكرار
            //بستخدمها لما  بكون عارف اني محتاج استخدم  الكود دا ف حته تانيه مش مش هعد اعمل كوبي بيست كل شويه
            //اعاده الاسخدام reusability انا بكتبها مره واحده ةاندهلها بقا 

            //------------------------------------------------------------------------
            //مكونه من حاجتين functionال 
            //1-prototype مكون من
            //-----
            // 1.1 segneture 
            //ولا اي int , string , char  يعني الفنكشن هترجع اي << return type 
            //لازم يدل الاسم بتاعها هي بتعمل اي << name 
            // parametar
            //ومش شرط الفنكشن ترجع حاجه هي ممكن بتطبع بس  void >> مش هترجع حاجه
            //-----
            //1.2 body 
            // اي اللي جوا الفنكشن دي
            //-------

            //2-calling هنادي عليها فين 
            //مينفعش اكتب فنكش جوا فنكشن main بس مينفعش اكتبها جوا ال main اي فنكشن لازم انادي عليها جوا ال

            #endregion

            #region Ex 1
            //عندي اراي عايز اطبع المتوسط بتاعها
            //double[] num = { 10, 4, 2, 4 };
            //double sum = 0;
            //for (int i = 0; i < num.Length; i++)
            //{
            //    sum += num[i];
            //}
            //double ava = sum / num.Length;
            //Console.WriteLine("avarage = " + ava);

            //طب لو عندي اراي تانيه وعايز اطبع المتوسط برضو 

            //double[] num2 = { 10, 20, 30, 40, 50 };
            //double summ = 0;
            //for (int i = 0; i < num2.Length; i++)
            //{
            //    summ += num2[i];
            //}
            //double ava2 = summ / num2.Length;
            //Console.WriteLine("avarage = "+ava2);

            //وانادي عليهاfunction  طب ما كده انا بكرر الكود ودا غلط
            //function الحل هنا اني اعمل   

            //int[] num = { 10, 20, 30 };
            //CalculateAverage(num);

            #endregion

            #region EX2
            //print(); // هيطبع * 10 مرات
            #endregion

            #region EX3
            // هو لازم كل مره اطبع * مبنفعش اغيرها ؟ ااه ينفع اني هبعت معاها براميتار
            //printpattern("/"); // هيطبع / 10 مرات
            #endregion

            #region EX4 
            //printpattern("/", 5); // هيطبع / 5 مرات
            // لازم التزم بترتيب البارميتار ونا بنادي
            #endregion

            #region EX5 
            // printpatterndefult("/", 5); // هيطبع / 5 مرات// passing by order
            // // لازم التزم بترتيب البارميتار ونا بنادي

            //// -------------------------------------------------

            // Console.WriteLine();
            // printpatterndefult("-"); //defult هيطبع - 10 مرات

            //// -------------------------------------------------

            //// Console.WriteLine();
            //// printpatterndefult(11); //كده ايرور لاني ملتومتش ب الترتيب invalid

            // //-------------------------------------------------

            // // طب يعم انا عايز انادي بترتيب مختلف !خلاص يبقا ساعتها هتنادي ب حاجه تانيه
            // printpatterndefult(count: 5, pattern: "/"); // هيطبع / 5 مرات// passing by name

            #endregion

            #endregion

            #region value type parametar
            //by reference ولا  by value هشوف بقا انا هبعته  value type النوع عندي 
            #region pass by value
            //  في العمليات التي تعتمد فقط على قراءة القيم، مثل الحسابات أو طباعة البيانات.زي جمع رقمين
            //  أي تغييرات تُجرى على البارامتر داخل الدالة لا تؤثر على المتغير الأصلي.

            #region  ex swap
            // int a = 3;
            // int b = 7;
            // Console.WriteLine($"A before swap = {a}");//3
            // Console.WriteLine($"b before swap = {b}");//7
            // swap(a, b);
            // Console.WriteLine($"a after swap = {a}");//3
            // Console.WriteLine($"b after swap = {b}");//7
            ////يحصل ؟؟ swap  ليه طلعت نفس القيم منغير م ال
            //// بتاعها ف هتطبع منغير اي تغييرaddress باعت القيم نفسها مش ال pass by value عشان انا عامل
            ////pass by refrence يحصل محتاج اعمل  swap عشان ال 
            #endregion


            #endregion


            #region pass by refrence
            // تبديل قيمتين،
            //إذا كانت الدالة تحتاج إلى إرجاع أكثر من نتيجة واحد
            //object , array , swap  ذا كانت البيانات كبيرة مثل  
            #region ex sawp
            ////pass by refrence يحصل محتاج اعمل  swap عشان ال 
            //#region  ex swap
            //int a = 3;
            //int b = 7;
            //Console.WriteLine($"A before swap = {a}");//3
            //Console.WriteLine($"b before swap = {b}");//7
            //swap(ref a, ref b);
            //Console.WriteLine($"a after swap = {a}");//7
            //Console.WriteLine($"b after swap = {b}");//3
            ////عادي swap  هنا عمل ال

            #endregion

            #endregion

            #endregion

            #region refernce type parametar
            //by reference ولا  by value هشوف بقا انا هبعته  refernce type النوع عندي 
            //ف معنديش مشكله استخدم دي او دي array  طالما انا بغير ف عنصر جوا ال
            //عشان التغيير يسمع pass by refernceنفسها مش ف العناصر اللي فيها مثلا هعنل اوبجكت جديد واحط قيم فيه استخدم  array لو هعلب ف ال
            #region pass by value
            //  في العمليات التي تعتمد فقط على قراءة القيم، مثل الحسابات أو طباعة البيانات.زي جمع رقمين
            //  أي تغييرات تُجرى على البارامتر داخل الدالة لا تؤثر على المتغير الأصلي.

            #region sumarray
            // //انا عملت الفنكشن فوق لاوم بقا اعمل اراي ياخد منها الارقام
            // // لو الاراي جاهوع عندي
            // int[] num = { 1, 2, 3 };
            // int result = sumarray(num);
            //// عملت اراي وعملت فريبال جديد خليته يساوي المجموع اللي ف الفنكشن
            // Console.WriteLine(result);
            //------------------------------------------------------
            // لو هاخدها م اليوزر
            //Console.WriteLine("please enter size of array");
            //int items = int.Parse(Console.ReadLine());
            //int[] num2 = new int[items];

            //for (int i = 0; i < items; i++)
            //{
            //    Console.WriteLine($"Enter element {i + 1}:");
            //    num2[i] = int.Parse(Console.ReadLine());

            //}
            //int result2 = sumarray(num2);
            //    Console.WriteLine(result2);


            #endregion

            #endregion

            #region pass by refrence ref
            // تبديل قيمتين،
            //إذا كانت الدالة تحتاج إلى إرجاع أكثر من نتيجة واحد
            //object , array , swap  ذا كانت البيانات كبيرة مثل  


            #region sumarray
            //انا عملت الفنكشن فوق لاوم بقا اعمل اراي ياخد منها الارقام
            //لو الاراي جاهزه عندي
            //int[] num = { 1, 2, 3 };
            //int result = sumarray(ref num);
            //// اراي وعملت فريبال جديد خليته يساوي المجموع اللي ف الفنكشن
            //Console.WriteLine(result);//6


            #endregion

            #region sumarray معدل
            //// انا عملت الفنكشن فوق لاوم بقا اعمل اراي ياخد منها الارقام
            //// لو الاراي جاهزه عندي
            // int[] num = { 1, 2, 3 }; //{انا معرف اراي فوق {5,6,4
            // int result = sumarray(ref num);
            // // اراي وعملت فريبال جديد خليته, يساوي المجموع اللي ف الفنكشن
            // Console.WriteLine(result);// 15 خد الاراي الجديده


            #endregion

            #endregion

            #endregion

            #region pssing by out
            // واحده بس مينفعش تعمل كذا حاجه مع بعض task بتعمل  functionمعروف ان ال
            //pssing by outلاكتر من حاجه باستخدامreturn انا هعمل 

            //int a = 10;
            //int b = 2;
            //int sumresult ;
            //int mulresult ;
            //SumMul(a, b, out sumresult, out mulresult);
            //Console.WriteLine($"sum of {a} + {b} is : {sumresult}");
            //Console.WriteLine($"mul of {a} * {b} is : {mulresult}");
            #endregion

            #region params >> direct بتعتي value هبعت ال
            //// معناها اني بنادي ع الفنكشن وببعتلها القيم بتعتي علي طول منغير مثا م اخليها تاخدها من اراي
            ////انا عملت الفنكشن فوق مش لازم بقا اعمل اراي ياخد منها الارقام
            ////int[] num = { 1, 2, 3 };
            //int result = sumarray(1, 2, 3, 9);
            //Console.WriteLine(result);//15

            #endregion

            #region Boxing & unBoxing
            //كده implicit & explicit castingبعمل تحويل زي ال 
            //Boxing >> casting from [value type] to [reference type] >>implicit
            //UNBoxing >> casting from [reference type] to [value type] العكس>> explicit
            //Boxing == implicit == safe casting >> From  [Value Type] To Object [ReferenceType]
            ////UNBoxing == explicit == unsafe casting >> From [reference type] to [value type]

            #region ex1
            //object obj;
            //// Declare Foe Refernce Of Type "Object", Refering To Null
            //// This Refernce OBJ Can Refer To an Instance From Type Object Or Any Another data type
            //obj = new object();
            //obj = new string("Rana");
            //obj = 'A';// Casting From Char [Value Type] To Object [ReferenceType] // Implicitly
            //obj = 3;// Casting From int [Value Type] To Object [ReferenceType]) // Implicitly //
            //obj = true;// Casting From boolean [Value Type] To Object [ReferenceType]) // Implicitly /

            ////--------------UNBoxing == explicit == unsafe casting
            /////bool flag  =obj; //  انا هنا عايز احط  الاةبجكت جوا البوليان ود مينفعش لازم اقوله يحولي
            //bool flag  = (bool )obj; // هنا التحويل تم وصادف انها قبلت
            #endregion

            #region ex2
            //  boxing >> safe casting >> implicit

            //int x = 5;
            //object o1 = x;
            ////objectجوا ال x انا بقراها م اليمين للشمال كاني بقوله حد ال 
            ////كبير ف هيشيل اي حاجه objectطبعا هينفع لان ال 

            //// x ----------------> o1 
            ////  unboxing >> unsafe casting >> explicit
            //object o2 = 10;
            ////int y = o2;// invalid
            //// xجوا ال o2 انا بقراها م اليمين للشمال كاني بقوله حد ال 
            //// صغير ف مش هيشيل اي حاجه اكبر   int مش هينفع لان ال 

            //int y = (int)o2; //explicit لازم اعحولعا ب ايدي

            //// o2 ----------------> x 

            #endregion

            #endregion

            #region nullable value type
            // انا بستخدمها عشان يكون الكود شايل كل الاحتمالات 
            ////0 هي value typeبتاع ال defult value  احنا عارفين ان ال
            ////null هي reference typeبتاع ال defult value  احنا عارفين ان ال

            ////متفعش value typeبس ال null يشيل referenceينفع ال

            //int x ; // valid
            //x = 10; // valid
            ////int age = null; // invalid because it's nullable value type
            //// لما احط بعد الداتا تايب علامه استفهام ؟null ب  variable  بخلي ال
            //int? age = null;// nullable<int> age; //او اي قيمه تانيه عادي null  معناها او كده ممكن يشيل 


            //int a = 5;
            // a >> allow value only
            //int? b;
            // b >> allow value + null

            //casting  متيجي نعمل
            //b = a; //implicity  //>> ف عادي null  بيشيل قيم وكمان بيشيل  b عادي مفهاش حاجه لان 
            // تعال نجرب العكس
            // a =b; // invalid  //>>  null  بيشيل قيم ومش بيشيل a مش هينفع  لان 
            //ب ايدي explicit casting لازم انا اعمل
            //a = (int)b;//unsafe casting>> //int هنا بقول انا متاكد ان عادي تحطها ف

            // احل المشكله دي ازاي ؟؟
            //int? k = 10;
            //k = null;

            //int l = 15;

            //k = l; // valide implicit castng
            //l = (int)k; //valide explicit castng but unsafe

            //ممكن اعمل كذا حاجه safe بتاعي castng عشان اخلي ال
            //if (k != null) //يعني شايله رقم null مش ب k لو 
            //{
            //    l = (int)k; //int تشيل قيمه  k هخلي 
            //}
            //else //null ب k لو
            //{
            //    l = 0; // 0 هخليها ب 
            //}

            // coalescing operator طريقه
            //l = k ?? 0;
            //k يتم استخدام قيمة not null تحتوي على قيمة k إذا كانت 
            //0 يتم استخدام القيمة الافتراضيه  null تحتوي على قيمة k إذا كانت 


            #endregion

            #region null propagation operator
            //double x = default; // 0 
            //int[]? num = default;//null
            //نفسها arrayمش ال null ب array ف انا بخلي القيم اللي جوا ال int بس اللي جواه refrence هو نوغه 
            //for (int i = 0; i < num.Length; i++)
            //{
            //}
            //nullعشان انا عندي قيم  NullReferenceException هو كده هيلف علي اي مهو هيطلع 
            //ميدخلش جوا اللوب null لاوم اهندل الدنيا بتعتي واقوله ان لو في

            //for (int i = 0; (num != null) && i < num.Length; i++)
            //// 2 condition الطبيعيLength وكمان اقل من الnull لازم اتاكد انو مش بيساوي
            //{
            //    Console.WriteLine(num[i]);
            //}
            //(num!= null)&& i < num.Length >> propagation or deReference

            //ولا لا nullعشان يشوف هي ب  num.Length طب منا كده عندي مشكله تانيه وهي تنو عايز كل مره بدخل اللول ويلف عليها اد ال

            //متدحلش اللوب اصلا في عندي طريقتين null انا عايز لو ب 

            //        if (num != null)
            //        {
            //            for (int i = 0; i < num.Length; i++)
            //            {
            //                Console.WriteLine(num[i]);
            //            }
            //        }
            //-----------------------------------------------------
            //        num != null ? num.Length : null;
            ////= if (num != null) هات num.Length >> else اطبعnull

            //-----------------------------------------------------
            //int length = num?.Length ?? 0;
            //0 لهاش هيطبع  length لو لقي ليها فيمه هيحطها ف 

            #endregion

            #region Exception Handlin And Pritective Code
            // Exception >> بتظهرلي ف مرحله الرن لما اعمل حاجه غلط ف الكود 
            //FormatException هيديني int بدل  string مثلا انا دخلت 
            //DivideByZeroException مثلا انا قسمت علي صفر هيديني
            //IndexOutOfRangeException مثلا عندي اراي وعايز اجيب رقم خارج جدود الاراي دي هيديني
            // ف انا لازم اهندل الدنيا دي م البدابه عندي
            //DoSomeCode();
            #endregion





        }
    }

}