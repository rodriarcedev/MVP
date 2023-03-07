
using System.Collections;

public interface IEnemyHealth 
{
    int Health { get; set; }
    void GetDamage(int damage);
    IEnumerator RegenerateTime();
}
