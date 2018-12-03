import socket
import thread

def PlayerThread(conn): 
    while True:
        msg = conn.recv(BUFFER_SIZE)
        msg = int(msg)
        player = data >> pos-1 & 0b1
        action = num >> pos-1 & 0b11111111
        data = num << 9
        print bin(player),"|",bin(action),"|",bin(data)

clients = 2
TCP_IP = "10.27.208.162"
TCP_PORT = 36763
BUFFER_SIZE = 1024
s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
s.bind((TCP_IP,TCP_PORT))
s.listen(clients)
#for i in range(clients):
conn, addr = s.accept()
thread.start_new_thread (PlayerThread, (conn,))
