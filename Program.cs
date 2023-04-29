using System;
using System.Collections.Generic;
class Program{
    public static void Main(string[]args){
        int x = int.Parse(Console.ReadLine());
        List<int>nodes = new List<int>();
        while(true){
            int node = int.Parse(Console.ReadLine());
            if (node >= x || node <0){
                break;
            }
            nodes.Add(node);
        }
        int Start = int.Parse(Console.ReadLine());
        int Finish = int.Parse(Console.ReadLine());
        int[,]adjMatrix = new int[x,x];
        for(int i =0;i<nodes.Count;i+=2){
            int fromNode = nodes[i];
            int toNode = nodes[i+1];
            adjMatrix[fromNode,toNode] = 1;
        }
        int[,]pathMatrix = new int[x,x];
        for(int i =0; i<x;i++){
            for(int j =0; j<x;j++){
                if(adjMatrix[i,j]==1){
                    pathMatrix[i,j]=1;
                }
            }
        }
        for (int k = 0; k < x; k++)
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    if (pathMatrix[i, j] != 1 && pathMatrix[i, k] == 1 && pathMatrix[k, j] == 1)
                    {
                        pathMatrix[i, j] = 1;
                    }
                }
            }
        }
        if (pathMatrix[Start, Finish] == 1)
        {
            Console.WriteLine("Reachable");
        }
        else
        {
            Console.WriteLine("Unreachable");
        }
    }
}
