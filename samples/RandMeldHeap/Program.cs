using RandMeldHeap;

Console.WriteLine("Randomized Meldable Heap Test");

var rmh = new RandomizedMeldableHeap<int>();
var theAnswer = rmh.Insert(-2);
var big = rmh.Insert(999);

for (int k = 9; k >= 0; k--)
    rmh.Insert(k * k);

rmh.UpdateKey(theAnswer, 42);
rmh.RemoveKey(big);

while (rmh.Count > 0)
    Console.WriteLine(rmh.Pop());

var rmh2 = new RandomizedMeldableHeap<int>();
var theAnswer2 = rmh2.Insert(-2);
var big2 = rmh2.Insert(999);

foreach (var k in Enumerable.Range(0,10))
    rmh2.Insert(k * k);

rmh2.UpdateKey(theAnswer2, 42);
rmh2.RemoveKey(big2);

while (rmh2.Count > 0)
    Console.WriteLine(rmh2.Pop());

Console.ReadKey(true);