#include "MyForm.h"
#include <Windows.h>
#include <math.h>
#include <iostream>
#include <ctime>
#include <string>
#include <cstdlib>
#include <cstring>
#include <random>
using namespace InSec1;
int WINAPI WinMain(HINSTANCE, HINSTANCE, LPSTR, int)
{
	Application::EnableVisualStyles();
	Application::SetCompatibleTextRenderingDefault(false);
	Application::Run(gcnew MyForm);
	return 0;
}

