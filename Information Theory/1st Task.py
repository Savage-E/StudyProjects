import numpy as np


def initialize():
    # Appends array p_y
    for i in range(n):
        p_y.append(0)
        for j in range(m):
            p_y[i] += p_xy[i, j]
    # Appends array p_x
    for i in range(m):
        p_x.append(0)
        for j in range(n):
            p_x[i] += p_xy[j, i]

    return p_x, p_y


def calculate(H_X, H_Y, I_XY):

    for i in range(n):
        H_X -= p_x[i] * np.log2(p_x[i])

    for i in range(m):
        H_Y -= p_y[i] * np.log2(p_y[i])

    for i in range(n):
        for j in range(m):
            if p_xy[i, j] != 0.0:
                I_XY += p_xy[i, j] * np.log2(p_xy[i, j] / (p_x[i] * p_y[j]))

    return H_X, H_Y, I_XY


def file_output(H_X, H_Y, H_XY, H_YX, H_X_Y, I_XY):
    file = open('output.txt', 'w')
    file.write(f'H(X) = {round(H_X, 5)}\n')
    file.write(f'H(Y) = {round(H_Y, 5)}\n')
    file.write(f'H(X|Y) = {round(H_XY, 5)}\n')
    file.write(f'H(Y|X) = {round(H_YX, 5)}\n')
    file.write(f'H(XY) = {round(H_X_Y, 5)}\n')
    file.write(f'I(X;Y) = {round(I_XY, 5)}\n')
    file.close()


if __name__ == '__main__':
    p_xy = np.loadtxt("input.txt", delimiter=" ")

    n, m = p_xy.shape

    p_x = []
    p_y = []

    p_x, p_y = initialize()

    H_X = 0.0
    H_Y = 0.0
    I_XY = 0.0

    # По формулам
    H_X, H_Y, I_XY = calculate(H_X, H_Y, I_XY)
    # цепное правило энтропии
    H_XY = H_X - I_XY
    H_YX = H_Y - I_XY
    H_X_Y = H_X + H_Y - I_XY

    print(f"H(X) = {round(H_X, 5)}")
    print(f"H(Y) = {round(H_Y, 5)}")
    print(f"H(X|Y) = {round(H_XY, 5)}")
    print(f"H(Y|X) = {round(H_YX, 5)}")
    print(f"H(XY) = {round(H_X_Y, 5)}")
    print(f"I(X|Y) = {round(I_XY, 5)}")

    file_output(H_X, H_Y, H_XY, H_YX, H_X_Y, I_XY)
