import socket
import thread


def player_thread(conn):
    while True:
        msg = conn.recv(BUFFER_SIZE)
        msg = int(msg)
        player = msg >> 9+8*16-1 & 0b1
        action = msg >> 8*16-1 & 0b11111111
        data = msg << 9
        print bin(player),"|",bin(action),"|",bin(data)


clients = 2
TCP_IP = "localhost"
TCP_PORT = 36763
BUFFER_SIZE = 1024

s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
s.bind((TCP_IP,TCP_PORT))

s.listen(clients)
conn, addr = s.accept()
thread.start_new_thread (player_thread, (conn,))
