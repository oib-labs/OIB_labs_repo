#include <cmath>
#include <iostream>
#include <algorithm>
//Если потребуется в случайном порядке
/*
#include <string>
#include <msclr\marshal_cppstd.h>
*/
#pragma once

namespace Test {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;
	using namespace System::IO;
	using namespace System::Globalization;

	/// <summary>
	/// Сводка для MyForm
	/// </summary>
	public ref class MyForm : public System::Windows::Forms::Form
	{
	public:
		MyForm(void)
		{
			InitializeComponent();
			//
			//TODO: добавьте код конструктора
			//
		}

	protected:
		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		~MyForm()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::TextBox^ txtP;
	protected:

	protected:
	private: System::Windows::Forms::Label^ lbl1;
	private: System::Windows::Forms::Label^ label1;
	private: System::Windows::Forms::TextBox^ txtV;

	private: System::Windows::Forms::GroupBox^ groupBox1;
	private: System::Windows::Forms::Label^ label4;
	private: System::Windows::Forms::Label^ label3;
	private: System::Windows::Forms::Label^ label2;
	private: System::Windows::Forms::TextBox^ txtT;

	private: System::Windows::Forms::Label^ lbl3;
	private: System::Windows::Forms::GroupBox^ groupBox2;
	private: System::Windows::Forms::CheckBox^ checkBox6;
	private: System::Windows::Forms::CheckBox^ checkBox5;
	private: System::Windows::Forms::CheckBox^ checkBox4;
	private: System::Windows::Forms::CheckBox^ checkBox3;
	private: System::Windows::Forms::CheckBox^ checkBox2;
	private: System::Windows::Forms::CheckBox^ checkBox1;
	private: System::Windows::Forms::GroupBox^ groupBox3;
	private: System::Windows::Forms::Label^ label5;
	private: System::Windows::Forms::Button^ btnResult;
	private: System::Windows::Forms::TextBox^ TextL;

	private: System::Windows::Forms::TextBox^ TextA;

	private: System::Windows::Forms::TextBox^ TextS;
	private: System::Windows::Forms::TextBox^ TextPass;
	private: System::Windows::Forms::Label^ lblError;





	private:
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		void InitializeComponent(void)
		{
			this->txtP = (gcnew System::Windows::Forms::TextBox());
			this->lbl1 = (gcnew System::Windows::Forms::Label());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->txtV = (gcnew System::Windows::Forms::TextBox());
			this->groupBox1 = (gcnew System::Windows::Forms::GroupBox());
			this->TextL = (gcnew System::Windows::Forms::TextBox());
			this->TextA = (gcnew System::Windows::Forms::TextBox());
			this->TextS = (gcnew System::Windows::Forms::TextBox());
			this->label4 = (gcnew System::Windows::Forms::Label());
			this->label3 = (gcnew System::Windows::Forms::Label());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->txtT = (gcnew System::Windows::Forms::TextBox());
			this->lbl3 = (gcnew System::Windows::Forms::Label());
			this->groupBox2 = (gcnew System::Windows::Forms::GroupBox());
			this->checkBox6 = (gcnew System::Windows::Forms::CheckBox());
			this->checkBox5 = (gcnew System::Windows::Forms::CheckBox());
			this->checkBox4 = (gcnew System::Windows::Forms::CheckBox());
			this->checkBox3 = (gcnew System::Windows::Forms::CheckBox());
			this->checkBox2 = (gcnew System::Windows::Forms::CheckBox());
			this->checkBox1 = (gcnew System::Windows::Forms::CheckBox());
			this->groupBox3 = (gcnew System::Windows::Forms::GroupBox());
			this->TextPass = (gcnew System::Windows::Forms::TextBox());
			this->label5 = (gcnew System::Windows::Forms::Label());
			this->btnResult = (gcnew System::Windows::Forms::Button());
			this->lblError = (gcnew System::Windows::Forms::Label());
			this->groupBox1->SuspendLayout();
			this->groupBox2->SuspendLayout();
			this->groupBox3->SuspendLayout();
			this->SuspendLayout();
			// 
			// txtP
			// 
			this->txtP->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->txtP->Location = System::Drawing::Point(146, 13);
			this->txtP->Multiline = true;
			this->txtP->Name = L"txtP";
			this->txtP->Size = System::Drawing::Size(170, 28);
			this->txtP->TabIndex = 0;
			this->txtP->TextAlign = System::Windows::Forms::HorizontalAlignment::Right;
			this->txtP->KeyPress += gcnew System::Windows::Forms::KeyPressEventHandler(this, &MyForm::txtP_KeyPress);
			// 
			// lbl1
			// 
			this->lbl1->Location = System::Drawing::Point(6, 16);
			this->lbl1->Name = L"lbl1";
			this->lbl1->Size = System::Drawing::Size(95, 18);
			this->lbl1->TabIndex = 1;
			this->lbl1->Text = L"P(вероятность)";
			// 
			// label1
			// 
			this->label1->Location = System::Drawing::Point(6, 47);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(121, 23);
			this->label1->TabIndex = 2;
			this->label1->Text = L"V(скорость перебора)";
			// 
			// txtV
			// 
			this->txtV->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->txtV->Location = System::Drawing::Point(146, 44);
			this->txtV->Multiline = true;
			this->txtV->Name = L"txtV";
			this->txtV->Size = System::Drawing::Size(170, 28);
			this->txtV->TabIndex = 3;
			this->txtV->TextAlign = System::Windows::Forms::HorizontalAlignment::Right;
			this->txtV->KeyPress += gcnew System::Windows::Forms::KeyPressEventHandler(this, &MyForm::txtV_KeyPress);
			// 
			// groupBox1
			// 
			this->groupBox1->Controls->Add(this->TextL);
			this->groupBox1->Controls->Add(this->TextA);
			this->groupBox1->Controls->Add(this->TextS);
			this->groupBox1->Controls->Add(this->label4);
			this->groupBox1->Controls->Add(this->label3);
			this->groupBox1->Controls->Add(this->label2);
			this->groupBox1->Controls->Add(this->txtT);
			this->groupBox1->Controls->Add(this->lbl3);
			this->groupBox1->Controls->Add(this->txtV);
			this->groupBox1->Controls->Add(this->label1);
			this->groupBox1->Controls->Add(this->lbl1);
			this->groupBox1->Controls->Add(this->txtP);
			this->groupBox1->Location = System::Drawing::Point(12, 12);
			this->groupBox1->Name = L"groupBox1";
			this->groupBox1->Size = System::Drawing::Size(392, 241);
			this->groupBox1->TabIndex = 4;
			this->groupBox1->TabStop = false;
			// 
			// TextL
			// 
			this->TextL->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->TextL->Location = System::Drawing::Point(173, 189);
			this->TextL->Multiline = true;
			this->TextL->Name = L"TextL";
			this->TextL->ReadOnly = true;
			this->TextL->Size = System::Drawing::Size(122, 27);
			this->TextL->TabIndex = 11;
			this->TextL->TextAlign = System::Windows::Forms::HorizontalAlignment::Right;
			// 
			// TextA
			// 
			this->TextA->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->TextA->Location = System::Drawing::Point(173, 156);
			this->TextA->Multiline = true;
			this->TextA->Name = L"TextA";
			this->TextA->ReadOnly = true;
			this->TextA->Size = System::Drawing::Size(122, 27);
			this->TextA->TabIndex = 10;
			this->TextA->TextAlign = System::Windows::Forms::HorizontalAlignment::Right;
			// 
			// TextS
			// 
			this->TextS->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->TextS->Location = System::Drawing::Point(173, 123);
			this->TextS->Multiline = true;
			this->TextS->Name = L"TextS";
			this->TextS->ReadOnly = true;
			this->TextS->Size = System::Drawing::Size(122, 27);
			this->TextS->TabIndex = 9;
			this->TextS->TextAlign = System::Windows::Forms::HorizontalAlignment::Right;
			// 
			// label4
			// 
			this->label4->Location = System::Drawing::Point(10, 193);
			this->label4->Name = L"label4";
			this->label4->Size = System::Drawing::Size(100, 23);
			this->label4->TabIndex = 8;
			this->label4->Text = L"L (длина пароля)";
			// 
			// label3
			// 
			this->label3->Location = System::Drawing::Point(10, 160);
			this->label3->Name = L"label3";
			this->label3->Size = System::Drawing::Size(132, 23);
			this->label3->TabIndex = 7;
			this->label3->Text = L"А (мощность алфавита)";
			// 
			// label2
			// 
			this->label2->Location = System::Drawing::Point(10, 127);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(157, 23);
			this->label2->TabIndex = 6;
			this->label2->Text = L"S* (нижняя граница паролей)";
			// 
			// txtT
			// 
			this->txtT->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->txtT->Location = System::Drawing::Point(146, 78);
			this->txtT->Multiline = true;
			this->txtT->Name = L"txtT";
			this->txtT->Size = System::Drawing::Size(170, 28);
			this->txtT->TabIndex = 5;
			this->txtT->TextAlign = System::Windows::Forms::HorizontalAlignment::Right;
			this->txtT->KeyPress += gcnew System::Windows::Forms::KeyPressEventHandler(this, &MyForm::txtT_KeyPress);
			// 
			// lbl3
			// 
			this->lbl3->Location = System::Drawing::Point(6, 81);
			this->lbl3->Name = L"lbl3";
			this->lbl3->Size = System::Drawing::Size(133, 23);
			this->lbl3->TabIndex = 4;
			this->lbl3->Text = L"T(срок действия пароля)";
			// 
			// groupBox2
			// 
			this->groupBox2->Controls->Add(this->checkBox6);
			this->groupBox2->Controls->Add(this->checkBox5);
			this->groupBox2->Controls->Add(this->checkBox4);
			this->groupBox2->Controls->Add(this->checkBox3);
			this->groupBox2->Controls->Add(this->checkBox2);
			this->groupBox2->Controls->Add(this->checkBox1);
			this->groupBox2->Location = System::Drawing::Point(410, 12);
			this->groupBox2->Name = L"groupBox2";
			this->groupBox2->Size = System::Drawing::Size(158, 158);
			this->groupBox2->TabIndex = 5;
			this->groupBox2->TabStop = false;
			// 
			// checkBox6
			// 
			this->checkBox6->AutoSize = true;
			this->checkBox6->Location = System::Drawing::Point(6, 133);
			this->checkBox6->Name = L"checkBox6";
			this->checkBox6->Size = System::Drawing::Size(62, 17);
			this->checkBox6->TabIndex = 5;
			this->checkBox6->Text = L"Цифры";
			this->checkBox6->UseVisualStyleBackColor = true;
			// 
			// checkBox5
			// 
			this->checkBox5->AutoSize = true;
			this->checkBox5->Location = System::Drawing::Point(6, 110);
			this->checkBox5->Name = L"checkBox5";
			this->checkBox5->Size = System::Drawing::Size(73, 17);
			this->checkBox5->TabIndex = 4;
			this->checkBox5->Text = L"Символы";
			this->checkBox5->UseVisualStyleBackColor = true;
			// 
			// checkBox4
			// 
			this->checkBox4->AutoSize = true;
			this->checkBox4->Location = System::Drawing::Point(6, 87);
			this->checkBox4->Name = L"checkBox4";
			this->checkBox4->Size = System::Drawing::Size(127, 17);
			this->checkBox4->TabIndex = 3;
			this->checkBox4->Text = L"Русские маленькие";
			this->checkBox4->UseVisualStyleBackColor = true;
			// 
			// checkBox3
			// 
			this->checkBox3->AutoSize = true;
			this->checkBox3->Location = System::Drawing::Point(6, 64);
			this->checkBox3->Name = L"checkBox3";
			this->checkBox3->Size = System::Drawing::Size(115, 17);
			this->checkBox3->TabIndex = 2;
			this->checkBox3->Text = L"Русские большие";
			this->checkBox3->UseVisualStyleBackColor = true;
			// 
			// checkBox2
			// 
			this->checkBox2->AutoSize = true;
			this->checkBox2->Location = System::Drawing::Point(7, 40);
			this->checkBox2->Name = L"checkBox2";
			this->checkBox2->Size = System::Drawing::Size(140, 17);
			this->checkBox2->TabIndex = 1;
			this->checkBox2->Text = L"Латинские маленькие";
			this->checkBox2->UseVisualStyleBackColor = true;
			// 
			// checkBox1
			// 
			this->checkBox1->AutoSize = true;
			this->checkBox1->Location = System::Drawing::Point(6, 16);
			this->checkBox1->Name = L"checkBox1";
			this->checkBox1->Size = System::Drawing::Size(128, 17);
			this->checkBox1->TabIndex = 0;
			this->checkBox1->Text = L"Латинские большие";
			this->checkBox1->UseVisualStyleBackColor = true;
			// 
			// groupBox3
			// 
			this->groupBox3->Controls->Add(this->TextPass);
			this->groupBox3->Controls->Add(this->label5);
			this->groupBox3->Controls->Add(this->btnResult);
			this->groupBox3->Location = System::Drawing::Point(12, 259);
			this->groupBox3->Name = L"groupBox3";
			this->groupBox3->Size = System::Drawing::Size(392, 93);
			this->groupBox3->TabIndex = 6;
			this->groupBox3->TabStop = false;
			// 
			// TextPass
			// 
			this->TextPass->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->TextPass->Location = System::Drawing::Point(70, 10);
			this->TextPass->Multiline = true;
			this->TextPass->Name = L"TextPass";
			this->TextPass->Size = System::Drawing::Size(142, 29);
			this->TextPass->TabIndex = 3;
			// 
			// label5
			// 
			this->label5->Location = System::Drawing::Point(6, 16);
			this->label5->Name = L"label5";
			this->label5->Size = System::Drawing::Size(100, 23);
			this->label5->TabIndex = 1;
			this->label5->Text = L"Пароль:";
			// 
			// btnResult
			// 
			this->btnResult->Location = System::Drawing::Point(6, 51);
			this->btnResult->Name = L"btnResult";
			this->btnResult->Size = System::Drawing::Size(170, 36);
			this->btnResult->TabIndex = 0;
			this->btnResult->Text = L"Сформировать пароль";
			this->btnResult->UseVisualStyleBackColor = true;
			this->btnResult->Click += gcnew System::EventHandler(this, &MyForm::btnResult_Click);
			// 
			// lblError
			// 
			this->lblError->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->lblError->ForeColor = System::Drawing::Color::Red;
			this->lblError->Location = System::Drawing::Point(416, 183);
			this->lblError->Name = L"lblError";
			this->lblError->Size = System::Drawing::Size(152, 132);
			this->lblError->TabIndex = 7;
			this->lblError->TextAlign = System::Drawing::ContentAlignment::MiddleCenter;
			// 
			// MyForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(580, 364);
			this->Controls->Add(this->lblError);
			this->Controls->Add(this->groupBox3);
			this->Controls->Add(this->groupBox2);
			this->Controls->Add(this->groupBox1);
			this->Name = L"MyForm";
			this->Text = L"Генератор паролей";
			this->Load += gcnew System::EventHandler(this, &MyForm::MyForm_Load);
			this->groupBox1->ResumeLayout(false);
			this->groupBox1->PerformLayout();
			this->groupBox2->ResumeLayout(false);
			this->groupBox2->PerformLayout();
			this->groupBox3->ResumeLayout(false);
			this->groupBox3->PerformLayout();
			this->ResumeLayout(false);

		}
#pragma endregion
		/*S* = VT/P
		* S*=A^L
		*/
		char ds; // Символ десятичного разделителя
		int x1; // Вспомогательная переменная (имеется ли минус в строке)
	private: System::Void MyForm_Load(System::Object^ sender, System::EventArgs^ e) 
	{
		// Определение десятичного разделителя (точки или запятой)
		// из региональных настроек.
		NumberFormatInfo^ nfi = NumberFormatInfo::CurrentInfo;
		ds = (char)nfi->NumberDecimalSeparator[0];

		srand(time(0));
	}
	void txtP_KeyPress(Object^ sender, KeyPressEventArgs^ e)
	{
		// Если нажатая клавиша не цифровая.
		if (!Char::IsDigit(e->KeyChar))
			// Запрет на ввод более одного знака минуса.
			if (e->KeyChar != '-' || txtP->Text->IndexOf('-') != -1)
				// Запрет на ввод более одного десятичного разделителя.
				if (e->KeyChar != ds || txtP->Text->IndexOf(ds) != -1)
					// Если нажатая клавиша не является клавишей BackSpace.
					if (e->KeyChar != (char)Keys::Back)
						e->Handled = true;          // Запрет ввода

			// Запрет ввода повторных нулей в начале числа.
		if (e->KeyChar == (char)Keys::D0 ||
			e->KeyChar == (char)Keys::NumPad0)  // Если нажата клавиша 0
			if (txtP->Text->Length >= 1)        // Если строка не пустая
				if (txtP->Text[0] == '0' && txtP->SelectionStart < 2)
					e->Handled = true;             // Запрет ввода
			// Замена десятичного разделителя в начале числа на "0,".
		if (e->KeyChar == ds)
		{    // Если введен десятичный разделитель
			x1 = 0;
			if (txtP->Text != "" && txtP->Text[0] == '-') { x1 = 1; }
			if (txtP->Text->IndexOf(ds) == -1 &&
				txtP->SelectionStart == x1)
			{
				// Если десятичный разделитель уже есть, то 0 вставлять не нужно
				txtP->Text = txtP->Text->Insert(x1, "0");  // Вставка 0
				txtP->SelectionStart = x1 + 1;  // Текстовый курсор в конец
			}
		}

		// Перенос точки ввода минуса в начало (ввод минуса только спереди)
		if (e->KeyChar == '-' && txtP->Text->IndexOf('-') == -1)
			txtP->SelectionStart = 0;         // Текстовый курсор в начало
	}
	void txtV_KeyPress(Object^ sender, KeyPressEventArgs^ e)
	{
		// Если нажатая клавиша не цифровая.
		if (!Char::IsDigit(e->KeyChar))
			// Запрет на ввод более одного знака минуса.
			if (e->KeyChar != '-' || txtV->Text->IndexOf('-') != -1)
				// Запрет на ввод более одного десятичного разделителя.
				if (e->KeyChar != ds || txtV->Text->IndexOf(ds) != -1)
					// Если нажатая клавиша не является клавишей BackSpace.
					if (e->KeyChar != (char)Keys::Back)
						e->Handled = true;          // Запрет ввода

			// Запрет ввода повторных нулей в начале числа.
		if (e->KeyChar == (char)Keys::D0 ||
			e->KeyChar == (char)Keys::NumPad0)  // Если нажата клавиша 0
			if (txtV->Text->Length >= 1)        // Если строка не пустая
				if (txtV->Text[0] == '0' && txtV->SelectionStart < 2)
					e->Handled = true;             // Запрет ввода
			// Замена десятичного разделителя в начале числа на "0,".
		if (e->KeyChar == ds)
		{    // Если введен десятичный разделитель
			x1 = 0;
			if (txtV->Text != "" && txtV->Text[0] == '-') { x1 = 1; }
			if (txtV->Text->IndexOf(ds) == -1 &&
				txtV->SelectionStart == x1)
			{
				// Если десятичный разделитель уже есть, то 0 вставлять не нужно
				txtV->Text = txtV->Text->Insert(x1, "0");  // Вставка 0
				txtV->SelectionStart = x1 + 1;  // Текстовый курсор в конец
			}
		}

		// Перенос точки ввода минуса в начало (ввод минуса только спереди)
		if (e->KeyChar == '-' && txtV->Text->IndexOf('-') == -1)
			txtV->SelectionStart = 0;         // Текстовый курсор в начало
	}
	void txtT_KeyPress(Object^ sender, KeyPressEventArgs^ e)
	{
		// Если нажатая клавиша не цифровая.
		if (!Char::IsDigit(e->KeyChar))
			// Запрет на ввод более одного знака минуса.
			if (e->KeyChar != '-' || txtT->Text->IndexOf('-') != -1)
				// Запрет на ввод более одного десятичного разделителя.
				if (e->KeyChar != ds || txtT->Text->IndexOf(ds) != -1)
					// Если нажатая клавиша не является клавишей BackSpace.
					if (e->KeyChar != (char)Keys::Back)
						e->Handled = true;          // Запрет ввода

			// Запрет ввода повторных нулей в начале числа.
		if (e->KeyChar == (char)Keys::D0 ||
			e->KeyChar == (char)Keys::NumPad0)  // Если нажата клавиша 0
			if (txtT->Text->Length >= 1)        // Если строка не пустая
				if (txtT->Text[0] == '0' && txtT->SelectionStart < 2)
					e->Handled = true;             // Запрет ввода
			// Замена десятичного разделителя в начале числа на "0,".
		if (e->KeyChar == ds)
		{    // Если введен десятичный разделитель
			x1 = 0;
			if (txtT->Text != "" && txtT->Text[0] == '-') { x1 = 1; }
			if (txtT->Text->IndexOf(ds) == -1 &&
				txtT->SelectionStart == x1)
			{
				// Если десятичный разделитель уже есть, то 0 вставлять не нужно
				txtT->Text = txtT->Text->Insert(x1, "0");  // Вставка 0
				txtT->SelectionStart = x1 + 1;  // Текстовый курсор в конец
			}
		}

		// Перенос точки ввода минуса в начало (ввод минуса только спереди)
		if (e->KeyChar == '-' && txtT->Text->IndexOf('-') == -1)
			txtT->SelectionStart = 0;         // Текстовый курсор в начало
	}
private: System::Void btnResult_Click(System::Object^ sender, System::EventArgs^ e) {
	//Проверка ввода
	if (txtP->Text == L"")
	{
		lblError->Text = "Введите вероятность подбора пароля злоумышленником.";
		return;
	}
	if (txtV->Text == L"")
	{
		lblError->Text = "Введите скорость перебора паролей.";
		return;
	}
	if (txtT->Text == L"")
	{
		lblError->Text = "Введите срок действия пароля.";
		return;
	}
	if (checkBox1->Checked == false & checkBox2->Checked == false & checkBox3->Checked == false &
		checkBox4->Checked == false & checkBox5->Checked == false & checkBox6->Checked == false)
	{
		lblError->Text = "Выберите категории используемого алфавита.";
		return;
	}
	lblError->Text = L"";

	int n = 0; //Переменная-счетчик кол-ва символов в пароле
	int R = 0; //Для случайных чисел
	int k = 0; //Для случайных чисел
	int A = 0; //Кол-во символов в алфавите
	int N = 0; //Кол-во выбранных категорий
	int Length = 0; //Длина отдельного алфавита
	double P = Convert::ToDouble(txtP->Text); //Вероятность
	double V = Convert::ToDouble(txtV->Text); //Скорость перебора
	double T = Convert::ToDouble(txtT->Text); //Срок действия пароля
	double S = V * T / P; //Нижняя граница паролей
	this->TextS->Text = Convert::ToString(S);

	array<String^>^ LatinBig = { "A", "B", "C", "D", "E", "F", "G", "H", "I",
				   "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W",
				   "X", "Y", "Z" };

	array<String^>^ LatinSmall = { "a", "b", "c", "d", "e", "f", "g", "h", "i",
				   "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w",
				   "x", "y", "z" };

	array<String^>^ CyrillicBig = { "А", "Б", "В", "Г", "Д", "Е", "Ё", "Ж", "З",
				   "И", "Й", "К", "Л", "М", "Н", "О", "П", "Р", "С", "Т", "У", "Ф", "Х",
				   "Ц", "Ч", "Ш", "Щ", "Ь", "Ъ", "Ы", "Э", "Ю", "Я" };

	array<String^>^ CyrillicSmall = { "а", "б", "в", "г", "д", "е", "ё", "ж", "з",
				   "и", "й", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф", "х",
				   "ц", "ч", "ш", "щ", "ь", "ъ", "ы", "э", "ю", "я" };

	array<String^>^ Symbols = { "|", "/", "_", ":", "<", ">", "@", "#", "$", "%", "&",
									"!", "~", "+", "=", "-", "*", "(", ")", "?", ".", ",", "{",
									"}", "[", "]" "'", "`" };

	array<String^>^ Numbers = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };


	Random^ rnd = gcnew Random();
	//rand() % 2 - Случайное число (0 или 1)
	if (checkBox1->Checked)
	{
		N++;
		A += 26;
	}
	if (checkBox2->Checked)
	{
		N++;
		A += 26;
	}
	if (checkBox3->Checked)
	{
		N++;
		A += 33;
	}
	if (checkBox4->Checked)
	{
		N++;
		A += 33;
	}
	if (checkBox5->Checked)
	{
		N++;
		A += 28;
	}
	if (checkBox6->Checked)
	{
		N++;
		A += 10;
	}
	this->TextA->Text = Convert::ToString(A);

	double L = log(S) / log(A); //Длина пароля
	L = ceil(L); //Округление вверх
	int L2 = L; //Длина пароля в int
	this->TextL->Text = Convert::ToString(L);
	String^ Result;
	std::string str;
	while (n != L2)
	{
		R = rand() % 2;
		if (R == 1 || n < N)
			if (checkBox1->Checked)
			{
				Length = LatinBig->Length;  
				Result += LatinBig[rnd->Next(0, Length)];
				n++;
			}
		if (n == L2)
			break;
		R = rand() % 2;
		if (R == 1 || n < N)
			if (checkBox2->Checked)
			{
				Length = LatinSmall->Length;
				Result += LatinSmall[rnd->Next(0, Length)];
				n++;
			}
		if (n == L2)
			break;
		R = rand() % 2;
		if (R == 1 || n < N)
			if (checkBox3->Checked)
			{ 
				Length = CyrillicBig->Length;
				Result += CyrillicBig[rnd->Next(0, Length)];
				n++;
			}
		if (n == L2)
			break;
		R = rand() % 2;
		if (R == 1 || n < N)
			if (checkBox4->Checked)
			{ 
				Length = CyrillicSmall->Length;
				Result += CyrillicSmall[rnd->Next(0, Length)];
				n++;
			}
		if (n == L2)
			break;
		R = rand() % 2;
		if (R == 1 || n < N)
			if (checkBox5->Checked)
			{ 
				Length = Symbols->Length;
				Result += Symbols[rnd->Next(0, Length)];
				n++;
			}
		if (n == L2)
			break;
		R = rand() % 2;
		if (R == 1 || n < N)
			if (checkBox6->Checked)
			{ 
				Length = Numbers->Length;
				Result += Numbers[rnd->Next(0, Length)];
				n++;
			}
	}
	//Если потребуется полностью в случайном порядке, не забыть подключить библиотеки
	/*
	str = msclr::interop::marshal_as<std::string>(Result);
	std::random_shuffle(str.begin(), str.end());
	Result = msclr::interop::marshal_as<System::String^>(str);
	*/

	this->TextPass->Text = Result;

	//Изобретение велосипеда
	/*
	if (checkBox1->Checked)
	{
		R = rand() % 2; 
		if (R == 1)
		{
			k = rand() % (L2 - N - n + 1);
			Length = LatinBig->Length;
			for (int i = 0; i < k; ++i)
			{
				Result += LatinBig[rnd->Next(0, Length)];
				n++; 
			}
		}
	}
	if (checkBox2->Checked)
	{
		R = rand() % 2;
		if (R == 1)
		{
			k = rand() % (L2 - N - n + 1);
			Length = LatinSmall->Length;
			for (int i = 0; i < k; ++i)
			{
				Result += LatinSmall[rnd->Next(0, Length)];
				n++;
			}
		}
	}
	if (checkBox3->Checked)
	{
		R = rand() % 2;
		if (R == 1)
		{
			k = rand() % (L2 - N - n + 1);
			Length = CyrillicBig->Length;
			for (int i = 0; i < k; ++i)
			{
				Result += CyrillicBig[rnd->Next(0, Length)];
				n++;
			}
		}
	}
	if (checkBox4->Checked)
	{
		R = rand() % 2;
		if (R == 1)
		{
			k = rand() % (L2 - N - n + 1);
			Length = CyrillicSmall->Length;
			for (int i = 0; i < k; ++i)
			{
				Result += CyrillicSmall[rnd->Next(0, Length)];
				n++;
			}
		}
	}
	if (checkBox5->Checked)
	{
		R = rand() % 2;
		if (R == 1)
		{
			k = rand() % (L2 - N - n + 1);
			Length = Symbols->Length;
			for (int i = 0; i < k; ++i)
			{
				Result += Symbols[rnd->Next(0, Length)];
				n++;
			}
		}
	}
	if (checkBox6->Checked)
	{
		R = rand() % 2;
		if (R == 1)
		{
			k = rand() % (L2 - N - n + 1);
			Length = Numbers->Length;
			for (int i = 0; i < k; ++i)
			{
				Result += Numbers[rnd->Next(0, Length)];
				n++;
			}
		}
	}
*/
}
};
}
