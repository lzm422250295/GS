using System.Collections;
using System.Collections.Generic;

public abstract class IMonster
{
    protected string m_name; //名称
    protected int m_grade; //等级
    protected float m_maxHp; //血量
    protected float m_hp; //血量
    protected int m_speed; //速度
    protected float m_atk; //攻击力
    protected float m_hitRange; //攻击距离
    protected float m_hitCritical; //暴击率
    protected IPropertyCompute m_propertyCompute; //属性计算
    protected IRace m_race; //种族
    protected IEquipment m_equipment; //装备

    //攻击特效
    protected abstract void AttackEffect();

    //攻击
    public void Attack(IMonster Target)
    {
        AttackEffect();
    }

    //被攻击
    public abstract void UnderAttack(IMonster Target);
  
}
