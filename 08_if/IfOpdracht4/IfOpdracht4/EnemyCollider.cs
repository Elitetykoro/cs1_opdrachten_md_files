namespace IfOpdracht4
{
    internal class EnemyCollider
    {
        internal bool CanPassWall(Enemy enemy)
        {
            if(enemy.flying || enemy.subterranian) { return true; }
            else { return false; }
            //gebruik hier een || (OR)
			//je kan enemy.??? gebruiken om de eigenschap te testen, bv voor flying wordt het enemy.flying
            //vervang false, een enemy mag door een muur als 1 van  (flying,incoporial,subterranian) true is;
        }
        internal bool CanPassWater(Enemy enemy)
        {
            if (enemy.incoporial || enemy.swimmer) { return true; }
            //gebruik hier een || (OR)
            //je kan enemy.??? gebruiken om de eigenschap te testen, bv voor flying wordt het enemy.flying
            else { return false; }//vervang false, een enemy mag door een muur als 1 van  (flying,incoporial,subterranian,swimmer) true is;
        }
    }
}