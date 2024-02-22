**No 5 Soal Algoritma**

5) Terdapat integer X dimana 0 < X < Y. Bilangan ini dapat dipecah menjadi 2 part:
	A[0], A[1], ..., A[X − 1]  dan
	A[X], A[X + 1], ..., A[Y − 1].
Selisih di antara 2 part tersebut adalah 
	| (A[0] + A[1] + ... + A[X − 1])  −  (A[X] + A[X + 1] + ... + A[Y − 1]) |

Buatlah sebuah function untuk menghitung nilah selisih yang terkecil
	int functionSelisih(int[] X)

contoh :
a) input array X adalah :
	A[0] = 2
	A[1] = 5
	A[2] = 3
	A[3] = 6
Array tersebut dapat dipecah menjadi :
	X = 1,  selisih = |2 − 14| = 12
	X = 2,  selisih = |7 − 9| = 2
	X = 3,  selisih = |10 − 6| = 4 

output selisih nilai terkecil adalah  2.

b) input array X adalah :
	A[0] = 3
	A[1] = 1
	A[2] = 2
	A[3] = 4
	A[4] = 3
Array tersebut dapat dipecah menjadi :
	X = 1,  selisih = |3 − 10| = 7
	X = 2,  selisih = |4 − 9| = 5
	X = 3,  selisih = |6 − 7| = 1
	X = 4,  selisih = |10 − 3| = 7 

output selisih nilai terkecil adalah 1.


**Jawaban**

Projek ini adalah jawaban dari soal no 5 yang tertera diatas. Projek ini memiliki 1 metode fungsi yang digunakan untuk menyelesaikan isu yang diberikan.

Fungsi : functionSelisih Fungsi ini dibuat menggunakan kode-kode .NET yang sederhana dan string builder yang disesuaikan.

Kesimpulan Projek ini berjalan dan sesuai dengan ekspektasi, dilengkapi juga dengan Unit Test untuk melakukan pengujian input tertentu. 


**Structure Project No 5**

<img width="350" alt="image" src="https://github.com/ariqfakhrizal/NTT-Test-No-5/assets/160866505/1cc9dc3b-2c5a-47ce-9f63-30bd15f766f3">


**Result**

<img width="331" alt="image" src="https://github.com/ariqfakhrizal/NTT-Test-No-5/assets/160866505/5c949bf6-1e70-493c-aa65-a0f3e8261601">



**Unit Test**

<img width="350" alt="image" src="https://github.com/ariqfakhrizal/NTT-Test-No-5/assets/160866505/94b07a63-4fb0-4994-b87a-369fcc7e98a9">



