using Exc_Generics;

TestGenericRepository();

static void TestGenericRepository()
{
    GenericRepository<TestClass> genericRepository = new GenericRepository<TestClass>();

    TestClass testClass;

    genericRepository.Add(new TestClass("thing 1"));
    genericRepository.Add(new TestClass("thing 2"));
    genericRepository.Add(testClass = new TestClass("thing 3"));
    genericRepository.Add(new TestClass("thing 4"));
    genericRepository.Add(new TestClass("thing 5"));

    genericRepository.Remove(testClass);

    foreach (TestClass aTestClass in genericRepository.GetAll())
    {
        Console.WriteLine("Iterating: " + aTestClass.Text);
    }

    //Console.WriteLine("GetById: " + genericRepository.GetById(1));
}