
var x = new List<int>();
var test1 = new test<IEnumerable<>>();
test1.method(20);
var test = new test<string>();
test.method("costam");



class test<t> where t : IEnumerable<t>,IComparable<t>
{

    public ICollection<t> method(t tVar)  
    {
        return tVar;
    }
}

