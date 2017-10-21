#include<stdio.h>
#include<iostream>
#include<time.h>
#define kieudulieu int
using namespace std;

typedef struct xe {
	char Ten[50];
	int soBanhXe;
	long giaTri;
}Xe;


void liveSort(int *a, int n);
void selectionSort(kieudulieu *a, int n);
void insertSort(kieudulieu *a, int n);
void swap(kieudulieu *a, int i, int j);
void swap(Xe *a, int i, int j);
void quickSort(int *a, int left, int right);
void bubbleSort(kieudulieu arr[], int n);
void shakerSort(kieudulieu arr[], int n);
bool sosanh(int arr[], int i, int j);
bool sosanh(Xe arr[], int i, int j);
void main() {
	//int* mang = new int[20];
	int n;
	cout << "so ptu" << endl;
	cin >> n;
	int* mang = new int[n];
	srand(time(NULL));
	for (int i = 0; i < n; i++)
		mang[i]=rand()%100;
		//cin >> mang[i];
	cout << "\nMang chua sap xep: \t";
	for (int i = 0; i < n; i++)
		cout << mang[i]<<"\t";
	Xe a[] = {
		{"xe dap",2,1000},
		{"lambogini",4,30000},
		{"xe may",2,2000},
		{"ferali",4,25000}
	};
	while (1) {
		cout << "\nChon cach ban muon sap xep:\n";
		//cout << "\t1) Exchange Sort\n";
		cout << "\t1) Selection Sort\n";
		cout << "\t2) Insertion Sort\n";
		cout << "\t3) Bubble Sort\n";
		cout << "\t4) Shaker Sort\n";
		cout << "\t5) Quick Sort 1\n";
		int k=10;
		while (k < 1 || k>5) {
			cin >> k;
		}
		switch (k)
		{
		//case 1: liveSort(mang, n);
			//break;
		case 1:
			selectionSort(mang, n);
			break;
		case 2:
			insertSort(mang, n);
			break;
		case 3:
			bubbleSort(mang, n);
			break;
		case 4:
			shakerSort(mang, n);
			break;
		case 5:
			quickSort(mang, 0, n - 1);
			break;
		default:
			cout << "Chon cai gi vay @@";
			break;
		}

		cout << "\nMang DA sap xep: \t";
		for (int i = 0; i < n; i++) {
			cout << mang[i] << "\t";
		}
		cout << "\nBan co muon thu cach sap xep khac ko ? \n1.Co\t2.Khong\n";
		int conf=3;
		while (conf != 1 && conf != 2) {
			cin >> conf;
		}
		if (conf == 2) break;
	}
	
	system("pause");
}
void shakerSort(kieudulieu arr[], int n)
{
	int left = 0;
	int right = n - 1;
	int k = 0;
	while (left < right)
	{
		for (int i = left; i < right; i++)
		{
			if (sosanh(arr,i+1,i))
			{
				swap(arr[i], arr[i + 1]);
				k = i;
			}
		}
		right = k;
		for (int i = right; i > left; i--)
		{
			if (sosanh(arr,i,i-1))
			{
				swap(arr,i,i-1);
				k = i;
			}
		}
		left = k;
	}
}
bool sosanh(int arr[], int i, int j) {
	return arr[i] < arr[j];
}
bool sosanh(Xe arr[],int i, int j) {
	return arr[i].giaTri < arr[j].giaTri;
}
void bubbleSort(kieudulieu arr[], int n)
{
	int i, j;
	bool swapped;
	for (i = 0; i < n - 1; i++)
	{
		swapped = false;
		for (j = 0; j < n - i - 1; j++)
		{
			if (sosanh(arr,j+1,j))

			{
				swap(arr,j,j+1);
				swapped = true;
			}
		}
		if (swapped == false)
			break;
	}
}

void quickSort(int *a, int left, int right) {
	int pivot = (left + right) / 2;
	int i=left, j=right;
	while(i<j){
		while (a[i] < a[pivot])
			i++;
		while (a[j] > a[pivot])
			j--;
		if (i < j) {
			swap(a, i, j);
			
			i++;
			j--;
			/*cout << "|||||||\t";
			cout << i << "\t " << j;
			cout << endl;*/
		}
	}

	if (left<pivot) {
		quickSort(a, i, right);
	}
	if (right > pivot) {
		quickSort(a, left, j);
	}
}
void quickSort(Xe *a, int left, int right) {
	int pivot = (left + right) / 2;
	int i = left, j = right;
	while (i<j) {
		while (a[i].giaTri < a[pivot].giaTri)
			i++;
		while (a[j].giaTri > a[pivot].giaTri)
			j--;
		if (i < j) {
			swap(a, i, j);
			i++;
			j--;
		}
	}

	if (left<pivot) {
		quickSort(a, i, right);
	}
	if (right > pivot) {
		quickSort(a, left, j);
	}
}
void swap(kieudulieu *a,int i, int j)
{
	kieudulieu temp = a[i];
	a[i] = a[j];
	a[j] = temp;
}
void swap(Xe *a, int i, int j)
{
	Xe temp = a[i];
	a[i] = a[j];
	a[j] = temp;
}
void liveSort(int *a, int n) {
	for (int i = 0; i<n - 1; i++)
		for (int j = i + 1; j<n; j++)
			if (a[j] < a[i])
			{
				int temp = a[i];
				a[i] = a[j];
				a[j] = temp;
			}
}

void selectionSort(kieudulieu *a, int n) {
	int locMin;
	for (int i = 0; i < n; i++) {
		locMin = i;
		for (int j = i+1; j < n; j++)
		{
			if (sosanh(a,j,locMin))
				locMin = j;
		}
		if (locMin != i)
		{
			swap(a, i, locMin);
		}
	}
}

void insertSort(kieudulieu *a, int n) {
	for (int i = 1; i < n; i++) {
		kieudulieu temp = a[i];
		int j;
		for (j = i - 1; j >= 0; j--) {
			if (sosanh(a,i,j)) {
				a[j + 1] = a[j];
			}
			else
				break;
		}
		a[j + 1] = temp;
	}
}
