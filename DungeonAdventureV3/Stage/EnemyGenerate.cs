public class EnemyGenerate
{
    private List<EnTemplate> _enemy = new List<EnTemplate>();
    Random random = new Random();
    public int AddEnemy()   //生成敌人
    {
        _enemy.Clear();

        int amount = random.Next(1,7);

        for (int i = 0; i<amount; i++)
        {
            int type = random.Next(2);
            if (type == 0)
            {
                _enemy.Add(new Goblin());
            }
            else
            {
                _enemy.Add(new Skeleton());
            }
        }
        return amount;
    }
    public void RemoveEnemy(int index)  //删除数组内的一个类型
    {
        if (index >= 0 && index < _enemy.Count)
        {
            _enemy.RemoveAt(index);
        }
    }

    public void ClearEnemy() => _enemy.Clear();   //清空数组
    public int EnemyCount => _enemy.Count;        //获取数量

    public EnTemplate ThisEnemy(int index)  //获取数组内的一个类型
    {
        return _enemy[index];
    }
}