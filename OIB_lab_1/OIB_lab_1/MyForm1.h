#pragma once

namespace OIBlab1 {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

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
	private: System::Windows::Forms::Label^ label1;
	private: System::Windows::Forms::TextBox^ textBox1;
	private: System::Windows::Forms::Label^ label2;
	private: System::Windows::Forms::Button^ GeneratePass;
	private: System::Windows::Forms::Label^ QNum;
	private: System::Windows::Forms::Label^ Pass;
	protected:

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
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->textBox1 = (gcnew System::Windows::Forms::TextBox());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->GeneratePass = (gcnew System::Windows::Forms::Button());
			this->QNum = (gcnew System::Windows::Forms::Label());
			this->Pass = (gcnew System::Windows::Forms::Label());
			this->SuspendLayout();
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 14, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->label1->Location = System::Drawing::Point(38, 54);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(226, 32);
			this->label1->TabIndex = 0;
			this->label1->Text = L"Идентификатор";
			// 
			// textBox1
			// 
			this->textBox1->Location = System::Drawing::Point(310, 61);
			this->textBox1->Name = L"textBox1";
			this->textBox1->Size = System::Drawing::Size(199, 26);
			this->textBox1->TabIndex = 1;
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 14, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->label2->Location = System::Drawing::Point(38, 173);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(37, 32);
			this->label2->TabIndex = 2;
			this->label2->Text = L"Q";
			// 
			// GeneratePass
			// 
			this->GeneratePass->Location = System::Drawing::Point(44, 280);
			this->GeneratePass->Name = L"GeneratePass";
			this->GeneratePass->Size = System::Drawing::Size(236, 40);
			this->GeneratePass->TabIndex = 3;
			this->GeneratePass->Text = L"Сформировать пароль";
			this->GeneratePass->UseVisualStyleBackColor = true;
			this->GeneratePass->Click += gcnew System::EventHandler(this, &MyForm::GeneratePass_Click);
			// 
			// QNum
			// 
			this->QNum->AutoSize = true;
			this->QNum->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 14, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->QNum->Location = System::Drawing::Point(304, 173);
			this->QNum->Name = L"QNum";
			this->QNum->Size = System::Drawing::Size(188, 32);
			this->QNum->TabIndex = 4;
			this->QNum->Text = L"sampleNumQ";
			// 
			// Pass
			// 
			this->Pass->AutoSize = true;
			this->Pass->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 14, System::Drawing::FontStyle::Regular, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->Pass->Location = System::Drawing::Point(333, 280);
			this->Pass->Name = L"Pass";
			this->Pass->Size = System::Drawing::Size(170, 32);
			this->Pass->TabIndex = 5;
			this->Pass->Text = L"samplePass";
			// 
			// MyForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(9, 20);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(649, 360);
			this->Controls->Add(this->Pass);
			this->Controls->Add(this->QNum);
			this->Controls->Add(this->GeneratePass);
			this->Controls->Add(this->label2);
			this->Controls->Add(this->textBox1);
			this->Controls->Add(this->label1);
			this->Name = L"MyForm";
			this->Text = L"Pass Generator (10 var)";
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: System::Void GeneratePass_Click(System::Object^ sender, System::EventArgs^ e) {
		int IDLength = textBox1->Text->Length;
		int Q = IDLength % 6;
		this->QNum->Text = Convert::ToString(Q);

		array<String^>^ SmallAlphabet = {"а", "б", "в", "г", "д", "е", "ё", "ж", "з",
			"и", "й", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф", "х",
			"ц", "ч", "ш", "щ", "э", "ю", "я" };
		int AlphabetLength = SmallAlphabet->Length;

		array<String^>^ BigAlphabet = { "А", "Б", "В", "Г", "Д", "Е", "Ё", "Ж", "З",
			"И", "Й", "К", "Л", "М", "Н", "О", "П", "Р", "С", "Т", "У", "Ф", "Х",
			"Ц", "Ч", "Ш", "Щ", "Э", "Ю", "Я" };

		String^ outString;

		char outCharArr[10];
		auto rnd = gcnew Random();
		//Заполнение первых двух позиций случайными большими русскими буквами
		outString += BigAlphabet[rnd->Next(0, AlphabetLength)];
		outString += BigAlphabet[rnd->Next(0, AlphabetLength)];

		for (int i = 2; i <= 10 - Q - 2; i++) {
			outString += SmallAlphabet[rnd->Next(0, AlphabetLength)];
		}

		for (int i = 10 - Q - 1; i < 10; i++) {
			outString += Convert::ToString(rnd->Next(0, 9));
		}
		
		/*for (int i = 0; i < 10; i++) {
			outString+=(char)outCharArr[i];
		}*/
		this->Pass->Text = Convert::ToString(outString);
	}
};
}
