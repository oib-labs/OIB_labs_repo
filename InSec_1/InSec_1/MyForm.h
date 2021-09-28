#pragma once
#include <algorithm>
namespace InSec1 {

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
	private: System::Windows::Forms::TextBox^ txt_in;
	protected:

	private: System::Windows::Forms::Label^ label2;
	private: System::Windows::Forms::TextBox^ txt_out;

	private: System::Windows::Forms::Button^ bt_solve;
	private: System::Windows::Forms::Label^ label3;
	private: System::Windows::Forms::TextBox^ txt_q;

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
			this->txt_in = (gcnew System::Windows::Forms::TextBox());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->txt_out = (gcnew System::Windows::Forms::TextBox());
			this->bt_solve = (gcnew System::Windows::Forms::Button());
			this->label3 = (gcnew System::Windows::Forms::Label());
			this->txt_q = (gcnew System::Windows::Forms::TextBox());
			this->SuspendLayout();
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Location = System::Drawing::Point(33, 64);
			this->label1->Margin = System::Windows::Forms::Padding(4, 0, 4, 0);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(118, 17);
			this->label1->TabIndex = 0;
			this->label1->Text = L"Идентификатор:";
			// 
			// txt_in
			// 
			this->txt_in->Location = System::Drawing::Point(157, 60);
			this->txt_in->Margin = System::Windows::Forms::Padding(4, 4, 4, 4);
			this->txt_in->Name = L"txt_in";
			this->txt_in->Size = System::Drawing::Size(227, 22);
			this->txt_in->TabIndex = 1;
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Location = System::Drawing::Point(33, 250);
			this->label2->Margin = System::Windows::Forms::Padding(4, 0, 4, 0);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(91, 17);
			this->label2->TabIndex = 2;
			this->label2->Text = L"Ваш пароль:";
			// 
			// txt_out
			// 
			this->txt_out->Location = System::Drawing::Point(157, 246);
			this->txt_out->Margin = System::Windows::Forms::Padding(4, 4, 4, 4);
			this->txt_out->Name = L"txt_out";
			this->txt_out->ReadOnly = true;
			this->txt_out->Size = System::Drawing::Size(227, 22);
			this->txt_out->TabIndex = 3;
			// 
			// bt_solve
			// 
			this->bt_solve->Location = System::Drawing::Point(235, 135);
			this->bt_solve->Margin = System::Windows::Forms::Padding(4, 4, 4, 4);
			this->bt_solve->Name = L"bt_solve";
			this->bt_solve->Size = System::Drawing::Size(151, 46);
			this->bt_solve->TabIndex = 4;
			this->bt_solve->Text = L"Сгенерировать пароль";
			this->bt_solve->UseVisualStyleBackColor = true;
			this->bt_solve->Click += gcnew System::EventHandler(this, &MyForm::bt_solve_Click);
			// 
			// label3
			// 
			this->label3->AutoSize = true;
			this->label3->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 8.25F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(204)));
			this->label3->Location = System::Drawing::Point(33, 165);
			this->label3->Margin = System::Windows::Forms::Padding(4, 0, 4, 0);
			this->label3->Name = L"label3";
			this->label3->Size = System::Drawing::Size(20, 17);
			this->label3->TabIndex = 5;
			this->label3->Text = L"Q";
			// 
			// txt_q
			// 
			this->txt_q->Location = System::Drawing::Point(63, 161);
			this->txt_q->Margin = System::Windows::Forms::Padding(4, 4, 4, 4);
			this->txt_q->Name = L"txt_q";
			this->txt_q->ReadOnly = true;
			this->txt_q->Size = System::Drawing::Size(63, 22);
			this->txt_q->TabIndex = 6;
			// 
			// MyForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(8, 16);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(447, 370);
			this->Controls->Add(this->txt_q);
			this->Controls->Add(this->label3);
			this->Controls->Add(this->bt_solve);
			this->Controls->Add(this->txt_out);
			this->Controls->Add(this->label2);
			this->Controls->Add(this->txt_in);
			this->Controls->Add(this->label1);
			this->FormBorderStyle = System::Windows::Forms::FormBorderStyle::FixedDialog;
			this->Margin = System::Windows::Forms::Padding(4, 4, 4, 4);
			this->Name = L"MyForm";
			this->Text = L"MyForm";
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
		
		
		
	private: System::Void bt_solve_Click(System::Object^ sender, System::EventArgs^ e) {
		array<String^>^ big_letter = { "А","Б","В","Г","Д","Е","Ё","Ж","З","И","Й","К","Л","М","Н","О","П","Р","С","Т","У","Ф","Х","Ц","Ч","Ш","Щ","Ъ","Ы","Ь","Э","Ю","Я" };
		array<String^>^ small_letter = { "а","б","в","г","д","е","ё","ж","з","и","й","к","л","м","н","о","п","р","с","т","у","ф","х","ц","ч","ш","щ","ъ","ы","ь","э","ю","я" };
		String^ str1;
		str1 = txt_in->Text;
		String^ techn;
		String^ pass;
		int q = (str1->Length)%6;
		int len_alph = 33;
		txt_q->Text = Convert::ToString(q);
		int t;
		auto rnd = gcnew Random();
		for (int i = 1; i < 11; i++) {
			if (i == 1 || i == 2) {
				pass += big_letter[rnd->Next(0, len_alph)];
				
				
				

			}
			if (i >= 3 && i <= 10 - q - 1) {
				pass += small_letter[rnd->Next(0, len_alph)];
			}
			if (i >= 10 - q && i <= 10) {
				pass+= 0+rand() % 9;
			}
		}
	txt_out->Text = pass;
	//txt_out->Text = Convert::ToString((char)11);
	}
};
}
