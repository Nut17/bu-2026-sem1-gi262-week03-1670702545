using UnityEngine;


namespace Assignment.StudentSolution.LCT01
{
    public class Car
    {
        public string name;
        public float speed;
        public string color;

        public void Move()
        {
            Debug.Log("Move");
        }

        public void Turn()
        {
            Debug.Log("Turn");
        }



    }

    public class LCT01SyntaxClass
    {
        public void Start()
        {
            Car car1 = new Car();
            car1.name = "MyCar";
            car1.speed = 100f;
            car1.color = "Red";
            car1.Move();
            car1.Turn();
        }
    }
}
