TrainList list = new TrainList();

list.insertHead("SE1");
list.insertHead("SE2");
list.insertTail("SE3");

System.Console.WriteLine(
    "1- Make a list of trains\n"+
    "2- Show the trains and carriages\n"+
    "3- Add a train\n"+
    "4- Add carriages to a train\n"+
    "other- Exit"
);

bool loop = true;
while (loop) {
    System.Console.Write("\nYou choose: ");
    switch (Console.ReadLine()) {
        case "1": list.Initialize(); break;

        case "2": list.printTrainandCarriage(); break;

        case "3": list.insertTrain(); break;

        case "4": list.insertCarriage(); break;
    }
}

list.printTrainandCarriage();