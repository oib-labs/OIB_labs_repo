#include "MyForm1.h"
#include <Windows.h>
#include <math.h>
#include <iostream>
#include <ctime>
#include <string>
#include <cstdlib>
#include <cstring>
#include <random>

using namespace OIBlab1;

[STAThread]
int WINAPI WinMain(HINSTANCE, HINSTANCE, LPSTR, int) {
	Application::EnableVisualStyles();
	Application::SetCompatibleTextRenderingDefault(false);

	OIBlab1::MyForm form;
	Application::Run(gcnew MyForm);
}

