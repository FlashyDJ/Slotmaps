using RandMeldHeap;

Console.WriteLine("Randomized Meldable Heap Demo");

var rmh = new RandomizedMeldableHeap<int>();
var theAnswer = rmh.Insert(-2);
var big = rmh.Insert(999);

foreach (var k in Enumerable.Range(0,10))
    rmh.Insert(k * k);

rmh.UpdateKey(theAnswer, 42);
rmh.RemoveKey(big);

while (rmh.Count > 0)
    Console.WriteLine(rmh.Pop());

Console.ReadKey(true);