Dwarfs standing on the shoulders of giants
Influence Chain: Length Problem (Based off Codingame's Shoulder of Giants) See README. 

Original Problem link: [Codingames - DWARFS STANDING ON THE SHOULDERS OF GIANTS](https://www.codingame.com/ide/puzzle/dwarfs-standing-on-the-shoulders-of-giants)
All images and description go to the rights of Codingames


The saying "Dwarfs standing on the shoulders of giants" refers to the importance of being able to build upon the work of our predecessors.
 
When we read texts, we often only get a small glance of this dependence: this person influenced that person. Thereafter, we learn that the second person, in turn influenced a third and so on. In this exercise we’re interested in the chain of influence and more precisely in finding the longest possible chain.​
 	Rules
We choose to represent each person by a distinct integer. If person #1 has influenced persons #2 and #3 and person #3 has influenced #4 then there is a succession of thoughts between #1, #3 and #4. In this case, it’s the longest succession and the expected result will be 3, since it involves 3 people.


![DG1](https://github.com/Goqwin/ShouldersGiants/assets/115321545/56671bc6-3a2c-4ec3-8573-d9b6dafed05d)


 
If we were to complete this example when we learn that person #2 also influenced persons #4 and #5, then the longest succession will still have a length of 3, but there will now be several of them.


![DG2](https://github.com/Goqwin/ShouldersGiants/assets/115321545/65d3940f-f13b-459e-bc74-c9ba2a5583ac)


 
If we now add that person #10 influenced person #11, the result remains 3. However, as soon as we learn that #10 also influenced #1 and #3, then the result becomes 4, since there is now a succession involving 4 people, which is #10, #1, #2, #5.


![DG3](https://github.com/Goqwin/ShouldersGiants/assets/115321545/6ec2043e-b335-48e4-9f81-e0a6449958af)

 
Note: It takes time for a thought to influence others. So, we will suppose that it is not possible to have a mutual influence between people, i.e. If A influences B (even indirectly through other people), then B will not influence A (even indirectly). Also, you can not influence yourself.

<h1 Game Input >
Input
Line 1: The number N of relationships of influence.

N following lines: a relationship of influence between two people in the form of X (whitespace) Y, which indicates that X influences Y. The relationships of influence are listed in any order.

Output
The number of people involved in the longest succession of influences.
Constraints
0 < N < 10000
0 < X, Y < 10000
</h1>


Concepts Learned/Applied
- Recursion 
- Data Structures (Graphs and Tree Traversal) 
- Algorithms (Depth First Structure)
- Dynamic Programming (Memoization for Time Complexity)
- Exception Handling and checks
