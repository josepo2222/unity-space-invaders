﻿using System.Collections;using System.Collections.Generic;using UnityEngine;public class enemigodispara : MonoBehaviour{    public GameObject disparo;    public Transform BulletSpawn;    public float startWait;    public float fireRate;    private float nextFire;    void Start()    {        StartCoroutine(FireShot());    }    IEnumerator FireShot()    {        yield return new WaitForSeconds(startWait);        while (true)        {            if (Time.time > nextFire)            {                nextFire = Time.time + fireRate;                Instantiate(disparo, BulletSpawn.position, BulletSpawn.rotation);                yield return new WaitForSeconds(fireRate);            }        }    }}  /*  public float tiempoentredisparos;    public float siguientedisparo = -1;    // Fuerza de lanzamiento del disparo    private float fuerza = 0.5f;    public Transform BulletSpam;    // Acceso al prefab del disparo    public Rigidbody2D disparo;    void Start()    {        siguientedisparo = Random.Range(1, 3.0f);        tiempoentredisparos = Random.Range(3, 6.5f);    }    // Update is called once per frame    void Update()    {                // Disparo        if (Input.GetKeyDown(KeyCode.Space))        {            disparar();        }            }    void disparar()    {        // Hacemos copias del prefab del disparo y las lanzamos        Rigidbody2D d = (Rigidbody2D)Instantiate(disparo, BulletSpam.position, BulletSpam.rotation);        // Desactivar la gravedad para este objeto, si no, ¡se cae!        d.gravityScale = 1;        // Posición de partida, en la punta de la nave        //d.transform.Translate(Vector2.down * 10f);        // Lanzarlo        d.AddForce(Vector2.down * fuerza, ForceMode2D.Impulse);    }    }    /*    public float tiempoentredisparos;    public float siguientedisparo = -1;    public Rigidbody2D disparo;    private float fuerza = 0.5f;    // Use this for initialization    void Start () {        siguientedisparo = Random.Range(1, 3.0f);        tiempoentredisparos = Random.Range(3, 6.5f);	}		// Update is called once per frame	void Update () {		if(Time.time > siguientedisparo)        {            disparar();            siguientedisparo = Time.time + tiempoentredisparos;        }	}    void disparar()    {        // Hacemos copias del prefab del disparo y las lanzamos        Rigidbody2D d = (Rigidbody2D)Instantiate(disparo, transform.position, transform.rotation);        // Desactivar la gravedad para este objeto, si no, ¡se cae!        d.gravityScale = 0;        // Posición de partida, en la punta de la nave        d.transform.Translate(Vector2.down * 0.7f);        // Lanzarlo        d.AddForce(Vector2.down * fuerza, ForceMode2D.Impulse);    }}*/