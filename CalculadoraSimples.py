import tkinter as tk

def press_key(key):
    current = entry.get()
    entry.delete(0, tk.END)
    entry.insert(tk.END, str(current) + str(key))

def clear():
    entry.delete(0, tk.END)

def calculate():
    try:
        result = eval(entry.get())
        entry.delete(0, tk.END)
        entry.insert(tk.END, str(result))
    except Exception as e:
        entry.delete(0, tk.END)
        entry.insert(tk.END, "Erro")

# Criar a janela principal
root = tk.Tk()
root.title("Calculadora Simples")

# Entrada para exibir os números e o resultado
entry = tk.Entry(root, width=20, font=('Arial', 14))
entry.grid(row=0, column=0, columnspan=4)

# Botões
buttons = [
    '7', '8', '9', '/',
    '4', '5', '6', '*',
    '1', '2', '3', '-',
    '0', '.', '=', '+'
]

row_val = 1
col_val = 0

for button in buttons:
    tk.Button(root, text=button, padx=20, pady=20, font=('Arial', 14),
              command=lambda key=button: press_key(key) if key != '=' else calculate()).grid(row=row_val, column=col_val)
    col_val += 1
    if col_val > 3:
        col_val = 0
        row_val += 1

# Botão de Limpar
tk.Button(root, text='C', padx=20, pady=20, font=('Arial', 14), command=clear).grid(row=row_val, column=col_val, columnspan=4)

# Iniciar a interface gráfica
root.mainloop()
