Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Windows.Forms

Public Class StackView
   Inherits UserControl
   Private stackStrip As ToolStrip
   Private WithEvents mailStackButton As ToolStripButton
   Private WithEvents calendarStackButton As ToolStripButton
   Private WithEvents contactsStackButton As ToolStripButton
   Private WithEvents tasksStackButton As ToolStripButton

   Private components As System.ComponentModel.IContainer = Nothing

   Private Shared mailBmp As Bitmap
   Private Shared calendarBmp As Bitmap
   Private Shared contactsBmp As Bitmap
   Private Shared tasksBmp As Bitmap
   Private Shared shortcutBmp As Bitmap
   Private Shared folderBmp As Bitmap
   Private Shared notesBmp As Bitmap

   Private Shared mailBmpEnc As String = "Qk32BgAAAAAAADYAAAAoAAAAGAAAABgAAAABABgAAAAAAAAAAADEDgAAxA4AAAAAAAAAAAAA7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7uv4yFvouEvYmDu4eBuYV/t4N9tYB7s355sXt3tntxsnhwsHZurXNsrHFrp21pomlnoGdlnmVjnWNi7u7u7u7u7u7u7u7u7u7uwY6H9N3C/vDa/ejM+tSp+cye98OS9bqI87F/87KA8qt68KRy76Bu7phl7ZVi7JVi54xb0ntSoGVj7u7u7u7u7u7u7u7u7u7uwo+Ix6WZ9ujb//bn/u/b/OfL++HA+9iv+tev+tSr+tKo+cyg+Mic9b+S9LqM8al35ZZmoXBSoWdk7u7u7u7u7u7u7u7u7u7uxZSN9ejayaOY9uvh//js/vXo/e/a/evS/OfL/OTF+927+9u1+tSq+tKl+cqW8buFqHZa7JVdn2hm7u7u7u7u7u7u7u7u7u7uxZSN//ns9ercxqKV+O7k//nw//fu//fr/vTl/u/c/uvU/eLB/N+7+tev8b6Hq3pe+Lh6/69qoWpp7u7u7u7u7u7u7u7u7u7ux5eP//vv//vw9OncxKOX9+7m//v1//nz//jx//bs/+7Z/erQ/eTC8syiqntg+M6a/9Oh/8CFom1s7u7u7u7u7u7u7u7u7u7uypqS//z4//v28ebYza2evp6V7+Lb8uzl8+3l8uvk9Ore9ejZ6NO/poVyt4xx5b2T/9ap/8ybpXFw7u7u7u7u7u7u7u7u7u7uzJ2V///87uPbzaye/fv6/fv5v6GTvKCQvJ+Nu5qIupmJt5uKsZWE+u3e+unYo4Jq572O/9KjqHd17u7u7u7u7u7u7u7u7u7uzqCX7OHbzKud/fr58url5tnQ5dfO5dfN5dfM5NbM49TI3Mq+3Mm93Mm8382/+unbrIJp57WGrH597u7u7u7u7u7u7u7u7u7uz6GZ0LGj6uHa/fv67OLc6+Hb7eTd7ePd7eLb7eLb7uPb9e7l9evk9uvj9+zh/PHlzr61r4VtsoWC7u7u7u7u7u7u7u7u7u7u0aKXfdb/8uzn///////////////////////+//37/Pn3+fXv9fHp8+vl8enk7uXe1si/L6f3tYeC7u7u7u7u7u7u7u7u7u7uy6mkdM3/+vf1/////////////////////fz8/Pv69fPx7vDw7O/w2OfvxN/swt/thMXnK6ftr4SC7u7u7u7u7u7u7u7u7u7u1KeevuX6nNf2rN/7nNz9h9X+b8z+VMb/RsT/RsT/PsP/Obz7NLT2MbL0K6vuJ6XpKKfrLqrvr4J/7u7u7u7u7u7u7u7u7u7u28jC0rSo0O36yOv7x+r7v+f8suP9o97+jtj+idn+htX/e83/a8f/XcD/Tbn/SLf/R7b/rJKJ7u7u7u7u7u7u7u7u7u7u7u7u7u7u6ePi07ew29zd1e/61O/60e77y+z8vun9reH+mNn+gdH/ccj/ZMP/Vr3/t7/CuKCX7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u6uXk2b621rux1fH63fL61/L7y+/8u+f9pt7+jNT+cMn/XcH/rZyW1c3L7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u6N/d07Op3d7f2/P60vD7xez8r+H9k9X+kr/cv6Wb7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u6uXk2L612cG31e73yOv7seL8uKWezLex7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u6eHg1LOpzaeayaqh4dvb7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u"
   Private Shared calendarBmpEnc As String = "Qk32BgAAAAAAADYAAAAoAAAAGAAAABgAAAABABgAAAAAAAAAAADEDgAAxA4AAAAAAAAAAAAA7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7uuKOUkXxqemNOalM8YEgwYEgwYkoxYUgwYEgwY0szYkoxYEgwYEgwYEgwYEgwZEszYUgwYEgwY0oyYUgwYEgwYEgw7u7u7u7uuqWW6tPE27qlxKCLu5d837OUzKGCt41xsYpt37OUzKGCt41xrodq37OUzKGCt41xrodq37OUzKGCt41xrodqZk447u7u7u7uvKaX//fz/+3i/NvFwJl6/+nb/d3H+c+1vJV2/+HP/tW8/MWluZJz/9vG/9Gw+8OfuJFy/86y/sKf97eSuJFyYEgw7u7u7u7uvaiZ//j2//Hq/OTY0qiL/+7h/+TR/N3J0KWI/+TU/9vE/9S4zqOF/+LR/9zE/sywzaKE/9e//8yt/sWizaKEYEgw7u7u7u7uv6qb//v5//j1//bx5Lug//Ho//Dl/+nb5Lqg/+fZ/+LQ/97I5Lqf/+XU/+HN/9zF5Lqf/9bC/9S7/9C05LqfYEgw7u7u7u7uwauc4bib1ayOxZyBvpd74LaY0qiKwJd7uJF14LWWz6WGvJJ2D0XuBTnjBjXQAiy8ACm137OUzKGCt41xrodqYEgw7u7u7u7uxK6f//v6/Ozg/eHQx6CC/+/m+uHQ+tjDwpt9/+re/+DM/9O4I1Tz/9zG/9O5/86wASu4/9fC98Sm87uYuJFyYEgw7u7u7u7uxrCh//39//n0/One1qyQ//v4/vHn+uHR06mM//Pt/+rc/+HMPGr0/+TU/93H/9i/AzHJ/+LP/9i++curzaKEYEgw7u7u7u7ux7Kj//39//38/fbw5Luh//z7/vj1/uzh5Lug//fx//bv/+vgWoH2/+/m/+vd/+PQAzTa/+XU/+XU/97J5LqfYUkx7u7u7u7uybOk47yh3rab1q2SzaWL4bqe2a+SzKKHwpqA4bmd1q2Ox52CbY/5WYD3OWb0IFP0Aj3t4Lib06iJwJV5sopwYEgw7u7u7u7uzbep//39//n1//Dn1a2S/vv6+uvh9+DPyqKG//Tt+eXX+eDSxJx//One+tzH+dC3v5d6/9/K+9C1+8akuI9yalM97u7u7u7u0Lyu//39//r3//f03bWa//7+/vXx+urg1q2R//f0/O3i+eTV06mM//fy/+7i+NfCz6WI/+zg/+DM/9CzyZ6Adl5I7u7u7u7u0sCy//38//39//395L2j//7+//79/vn45L2j//38//n2/vLr5L2j//37//n2/unf5L2j/+/l/+nc/+DN5L2jf2dS7u7u7u7u6KaG6KaG6KSE56OB56B+55565pt25phy5ZVt5ZJp5I5k5Itf5Iha44RV44FR4n5M4ntI4XhE23I812w00mkzyGAo7u7u7u7u6amK/93L/dfD/9a+/s+2/syy/sis/sSl/cGh/byb/LeV+7SO+rCJ+auC+ad9+KN3+KBx95xu95pq9pdn9pVkyGAo7u7u7u7u662P/+LQ/t/M/t3K/drG/dfC/dK8/c63/Mqx/Mer+sKk+r6f+bqY+LaT+LGM96yG9qmA9aV69aB19J1w9JpsyGAo7u7u7u7u7LKV7LKV662P6aeG56F/559855x45pp05pdw5ZRs5ZFo5I5j5Itf5Ihb44VW44JS4n9O4nxK4XpG4XdC4XU/2Ws27u7u7u7upJqU////pJqU////n5aQ////mZCL////kYmF////iIJ+////fnp2////dXJv////bGpo////ZGNi////XV5c////7u7u7u7u7u7uICUg6enpICUg6enpICUg6enpICUg6enpICUg6enpICUg6enpICUg3t7eICUg0NDQICUgvb29ICUguLi4ICUg7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u"
   Private Shared contactsBmpEnc As String = "Qk32BgAAAAAAADYAAAAoAAAAGAAAABgAAAABABgAAAAAAAAAAADEDgAAxA4AAAAAAAAAAAAA7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7uuqWWh3FeeWJNalM8YEgwYEgwYEgwYEgwYEgwYEgwYEgwYEgwYEgwYEgwYEgwYEgwYEgwYEgwYEgwYEgwYEgwYEgw7u7u7u7uuqWW//bx7t3T7trO7tfI79LB78658Mqy8MWq8cCi8buZ8raR8rKJ862C86l69KV09KFt9Z5o9Zxk9Zph9ZphYEgw7u7u7u7uu6aX//n2//fy//Xv//Lr//Dn/+3j/+re/+ja/+XW/+LR/+DN/93J/9rF/9jB/9W9/9O5/9G2/8+z/86x9ZphYEgw7u7u7u7uvKiZ//z6//r30M/SGlmtA0uuA0WfAz+RATmHADV9zr23/+PTs4t1roRuqX1mpHhgoXRcoXRcoXRc/9C09Z1mYEgw7u7u7u7uvqqb//79//z7FFe3N3rVSYrkQ4XeA0OaGW3eC02nGkF4/+fZ/+TV/+LQ/9/M/9zI/9rE/9fA/9W8/9O59KFtYEgw7u7u7u7uwKyd//////7+E1i3Z57pUZDoTY7nA0SbGGzeE2DIAzmD/+vfuZJ9s4t1roRuqX1mpHhgoXRcoXRc/9a99KV0YEgw7u7u7u7uwq6f////////GF69gKvkX5flA0WeGW7iA0+3GWzgEk+j/+7l/+zh/+nc/+bY/+TT/+HP/97L/9zH/9nD86t9YEgw7u7u7u7uxLCh////////tcDPE1StGly1yNXZ+fryBVG5BkGOz8rK//LqvpiEuZJ9s4t1roRuqX1mpHhgoXRc/93I87CHYEgw7u7u7u7uxrKk////////9fX1zdDTYWZsVFVWYWFhBkunubzC//jz//Xw//Ps//Do/+7k/+vf/+jb/+bX/+PS/+DO8raRYEgw7u7u7u7ux7Sm////////xMTEAAAAwcHBoqKihYWFVVVVn56d//r3//j0//bx//Tt//Hp/+/l/+zh/+nd/+fY/+TU8b2cYEgw7u7u7u7uybao////////ODg4LCws1tbWwcHBoqKihYWFZGRk//37//v5//n2//fy//Xv//Lr//Dn/+3j/+re/+ja8MOmYEgw7u7u7u7uy7iq////////U1NTSUlJtLS01dXVwcHBoqKidXV1///+//38/LeL+7SI+q+D+ap++KV496Bz9p1w/+vg8MmxZk437u7u7u7uzbqs////////fn5+Y2NjXV1dbW1tWFhYwcHBhISE//////////79//z7//v4//n1//bx//Tu//Lq/+/m78+6b1dB7u7u7u7uz7yu////////xcXFbGxsgoKCoaGhjo6OVVVVra2t/////////LeL+7SI+q+D+ap++KV496Bz9p1w//Pr79TEeWJN7u7u7u7u0L6w////////8vLyuLi4jY2NiIiIhYWFtLS08fHx//////////////////////38//z6//r3//j0//bw7tnMgm1Z7u7u7u7u0b+x//////////////////////////////////////////////////////////////79//z7//v4//n1//fyi3Zj7u7u7u7u0sCy0b+x0L6wz72vzrutzLqsy7iqybeoyLWmxrOkxLGiw6+hwa2fv6udvqmbvKiZu6aXuaWWuKOUt6KTtqGStaCR7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u"
   Private Shared tasksBmpEnc As String = "Qk32BgAAAAAAADYAAAAoAAAAGAAAABgAAAABABgAAAAAAAAAAADEDgAAxA4AAAAAAAAAAAAA7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u3N3fkXxqeGBLalE5cVc/c1lBf2JKl3RZiWhMe1xBb1M5aE42Zkw0Zk01aE42YUkxYkkxYkkxkod97u7u7u7u7u7u7u7u7u7uv62e+ezi69nQ7M6+7Miz6L+prI+rWFKqmHyk7rWU77OO77CM8LCK8bCH8a2F8qp98aV13pZnZkwz7u7u7u7u7u7u7u7u7u7uv62e//37/vr3/vTw+uvkwLnaJDO/BhmzJjTDybTG99K8+NC49syy9sms9sao9cOl8LiV8KR0aU417u7u7u7u7u7u7u7u7u7uwK6f//7+//z7/Pj3xcTmLDvBFynIMEXkIDbXVGHO6dHO+tzJ+tjD+dW++dK5+c+19sWn8qd2Y0kx7u7u7u7u7u7u7u7u7u7uw7Gj/////Pv9wcTsKDjFFCnMRVjuZHX1PlPoFzHSeHPJ+d3O+tzI+tjD+dS9+dG59seq8ayEaEw07u7u7u7u7u7u7u7u7u7uxrWm9vf9pKzoJjjNGi7TR1nreoj/j5v8ZXf0N0zlJjTPv7LP+t7O+tvI+tfC+dS998qv8K+LaU427u7u7u7u7u7u7u7u7u7u08W619v5Kz7XJjrfTl/ze4v/tLr59/Dyoab2Znb0LUPmNUTO1sXR+9/N+tvH+tjC99C277GNbVI47u7u7u7u7u7u7u7u7u7uy7qt6+3+kp74UGT4c4P/sbj+/Pr5/vj16ePykpz5Y3T0KDzfbHHR6dTS++HQ+tvG+dnD8bqabVI57u7u7u7u7u7u7u7u7u7uybeo////9ff/qLL/wsr//Pz///38/vv5/ff09e7wpav4YnP0KDzajYzQ6NPT/N7O+NrG8b+idFlA7u7u7u7u7u7u7u7u7u7uyriq////////+Pn//v7///////////38/vr2/vj08erwmaL6WWvyMELXmJbS9OPb+d/Q88mxc1Y97u7u7u7u7u7u7u7u7u7uzLqs//////////////////////////7+//36/vr3/vn0+fDvsLT1WmruNUbQta/V+uXX9M+6hWdP7u7u7u7u7u7u7u7u7u7uzryt//////////////////////////////7+//79//v3/vj0+O7wurz0TV3sSFTS08fa9t7PmXlh7u7u7u7u7u7u7u7u7u7uz72v/////////////////////fj1+Orh9uHW89TD88+78sew9NK99drNm5/xVWbwYWvV6dzgrIlw7u7u7u7u7u7u7u7u7u7u0L6w////////////////X4ycVYGSTHaIS21/SGN0SGJySF9vdnd9pZWQ89TDt7n1TF3oZGvOuJ2L7u7u7u7u7u7u7u7u7u7u0b+x////////////////dJmou+Xsmd3ofs/fdcXVcMHSbrrNbbHCbHJ69dTD++3nw8HuNUjqZGjJ7u7u7u7u7u7u7u7u7u7u0b+x////////////////i6q2pMnStuzzYYycdLG+fs/ed8jaXY2eRl1t8uDU++je/O7mzsnmUFCX7u7u7u7u7u7u7u7u7u7u0sCy////////////////3ufqdZuqx+30V3aFXoCPaZWkjdDeTWx8v7Ko/vr2/fTv/fTu+/XxnZSu7u7u7u7u7u7u7u7u7u7u6urr2Mq/0b+x0L6wz72vyLeqc5qpoMHLxfD3v+zzruXvkMjVaX6GwK6ewrChwa+gwK6fv62e4OHi7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u5ObnfKa1eaOxcpyrcJWkboiW4+Pj7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u"
   Private Shared shortcutBmpEnc As String = "Qk02AwAAAAAAADYAAAAoAAAAEAAAABAAAAABABgAAAAAAAAAAADEDgAAxA4AAAAAAAAAAAAA7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7ugICANzEsNzEsNzEsMi0oLCYiIx4bGxcUFRAOEAwKEAwKEAwKEAwKEAwK7u7u7u7ugICA/vbx693S69XL7NDB78278Max8MKp872i9Lia9LOV9bCP9rCKEAwK7u7u7u7ugICA/vn2/vbx/fHq/ezk7drPpZOL/d7O/NnG/NTA+9C5+8y09bCPEAwK7u7u7u7ugICA//38/vn2/vbwu7CpPzk118W7/eLV/d7O/NnG/NTA+9C59LOVEAwK7u7u7u7ugICA//////383trXMi4tSkM/++ri/Ojc/eLV/d7O/NnG/NTA9LiaEAwK7u7u7u7ugICA////////v769MzIxIyIhvLGm/ezk/Ojc/eLV/d7O/NnG872iFRAO7u7u7u7ugICA////////7+/vf35+EhIRNTAvw7St/ezk0LSnoYJy/d7O8MKpGxcU7u7u7u7ugICA/////////Pz81NTUPz8+ERAPQT07qJyUaFZQRzUr/eLV8MaxIx4b7u7u7u7ugICA/////////////Pz8rKysMjMyEhEQIBwaLSMhOCsl/Ojc7827LCYi7u7u7u7ugICA/////////////////f39pqamIiMjAwMCCwcHKyEf/ezk7NDBMi0o7u7u7u7ugICA////////////////0dHRZWVlJCQkCAgIAwICGxUU/fHq69XLNzEs7u7u7u7ugICA////////////////ra2tTExMSkpKRUVFNDMyLy4u/vbx693SNzEs7u7u7u7ugICA//////////////////////////////////////38/vn2/vbxNzEs7u7u7u7ugICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICAgICA7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u"
   Private Shared folderBmpEnc As String = "Qk02AwAAAAAAADYAAAAoAAAAEAAAABAAAAABABgAAAAAAAAAAADEDgAAxA4AAAAAAAAAAAAA7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7udYSPbHqFYG13UV1mQkxUMTpBIyowFx0iDhMYDhMYDhMYDhMYDhMYDhMYDhMY7u7ud4eSot/wcM3qSbjiN67bLanZJqHSIZjHII68HoOuGX+rFXypG3efH3KWFRwg7u7ueoqVquj2leX8hN/7dtf6atD3Xsf0UL7wQrTsNqvpK6TmIJrfFpDXG3efICct7u7ufY6YsOr2n+n7kuT8gt77ddb6ac/3Xcb0Tr3wQbTsNKroKqPmHZbcFXypLTQ77u7ugJGct+34qez7m+j7j+P8gN37c9X6aM73W8X0TbzwPrPtMqnoJJ7iEIK0O0NL7u7ug5WfvvD5q/D3pez7mOf7i+L8f937cdX6Zs33WMTzS7vwPbHsLKTjDIq/SVNc7u7uhpqjvvD5tu74sO76pOv6luf7ieL8ftz8cNX5Zc33WMTzSbrvNannDI/HV2Nr7u7uiJylvvD5tu74tu74q/D3ouz6lOb7iOH8fNz8b9P6Y8z3VcPzSbnvGZnPY3B67u7ui6CovvD5vvD5vvD5vvD5tPL4q+37oOn7leX8it/8f9j7dNL4aMr0XcDxY3B67u7ujqKrjqKrjqKrjaGrjKCpi5+oip2niZumh5qkhpmjhZehhJagg5Wgg5WgwsjM7u7uj6SssuTstu74tu74qez2kuHzjaGqucnP7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u1ePoj6Ssj6Ssj6Ssj6Ssj6Ss0tvf7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u"
   Private Shared notesBmpEnc As String = "Qk02AwAAAAAAADYAAAAoAAAAEAAAABAAAAABABgAAAAAAAAAAADEDgAAxA4AAAAAAAAAAAAA7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7ugam4SHGCRnGDQHKHN3CKMW2JLGeGK2aFLGSDLGOALWF8L153MFtzMFtx7u7u7u7ugam4atL8cNX/aND7OrblIKLYGqTVAY3KH6HXPKzkS7btVL/yVL/xQVpr7u7u7u7ugam4btT+YMz2MLHgDZTLAJviAJvdK6zfcNf+b9P/cNX/cNX/cNX/Q11u7u7u7u7ugaq4aM71KqzbD6bXNdH+KMb4G57Rc9n7cdf/ctf/ctf/ctf/ctf/RWBw7u7u7u7ugaq4VcXpA6DWLMzyKMTsAJfOR7zie+D+eN3/eN3/eN3/eN3/eN3/R2Ny7u7u7u7ugau4PLPcPsHlObjeLrPbFqDOZdP0fuP+feL/feL/feL/feL/feL/SGV07u7u7u7ugau6UbzheeP2f+T/f+T/f+T/f+X/f+b/f+T/f+T/f+T/f+T/f+T/SWV27u7u7u7uga6/dtHsguj/guj/guj/guj/guj/guj/guj/guj/guj/guj/guj/Smd37u7u7u7ug7DBjN7xhu/8hu/8hu/8iO7/iO7/iO7/iO7/iO7/iO7/iO7/iO7/S2h37u7u7u7uhLHDn+X3j/X/j/X/j/X/j/X/j/X/j/X/j/X/j/X/j/X/j/X/j/X/TGl37u7u7u7uh7XGsu/4mf//mf//mf//mf//mf//mf//mf//mf//mf//mf//mf//Tmt57u7u7u7uk8XWx/X7qv//qv//qv//qv//qv//qv//qv//qv//qv//qv//qv//UG177u7u7u7uk8bX2vv/zP//xP//xP//xP//xP//xP//xP//xP//xP//xP//xP//UW187u7u7u7uk8bXk8bXk8bXk8bXk8bXksTUjsPRjsDQjb7OjLvKhrPBg6q6gam4gam47u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u7u"

   ' Static constructor to initialize
   ' the form's static fields.
   Shared Sub New()
      ' Create the static bitmaps from Base64 encoding.
      CreateBitmaps()
   End Sub

   Public Sub New()
      Me.InitializeComponent()

      ' Assign icons to ToolStripButton controls.
      Me.InitializeImages()

      ' Set up renderers.
      Me.stackStrip.Renderer = New StackRenderer()
   End Sub

   ' This utility method assigns icons to each
   ' ToolStripButton control.
   Private Sub InitializeImages()
      Me.mailStackButton.Image = mailBmp
      Me.calendarStackButton.Image = calendarBmp
      Me.contactsStackButton.Image = contactsBmp
      Me.tasksStackButton.Image = tasksBmp
   End Sub


   ' This utility method creates bitmaps for all the icons.
   ' It uses a utility method called DeserializeFromBase64
   ' to decode the Base64 image data.
   Private Shared Sub CreateBitmaps()
      mailBmp = DeserializeFromBase64(mailBmpEnc)
      calendarBmp = DeserializeFromBase64(calendarBmpEnc)
      contactsBmp = DeserializeFromBase64(contactsBmpEnc)
      tasksBmp = DeserializeFromBase64(tasksBmpEnc)
      shortcutBmp = DeserializeFromBase64(shortcutBmpEnc)
      folderBmp = DeserializeFromBase64(folderBmpEnc)
      notesBmp = DeserializeFromBase64(notesBmpEnc)
   End Sub


   ' This utility method cretes a bitmap from 
   ' a Base64-encoded string. 
   Friend Shared Function DeserializeFromBase64(ByVal data As String) As Bitmap
      ' Decode the string and create a memory stream 
      ' on the decoded string data.
      Dim stream As New MemoryStream(Convert.FromBase64String(data))

      ' Create a new bitmap from the stream.
      Dim b As New Bitmap(stream)

      Return b
   End Function

   ' This method handles the Load event for the UserControl.
   Private Sub StackView_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
      ' Dock bottom.
      Me.Dock = DockStyle.Bottom

      ' Set AutoSize.
      Me.AutoSize = True
   End Sub

   ' This method handles the Click event for all
   ' the ToolStripButton controls in the StackView.
   Private Sub stackButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles mailStackButton.Click, calendarStackButton.Click, contactsStackButton.Click, tasksStackButton.Click
      ' Define a "one of many" state, similar to
      ' the logic of a RadioButton control.
      Dim item As ToolStripItem
      For Each item In Me.stackStrip.Items
         If item IsNot sender AndAlso TypeOf item Is ToolStripButton Then
            CType(item, ToolStripButton).Checked = False
         End If
      Next item
   End Sub

   Protected Overrides Sub Dispose(ByVal disposing As Boolean)
      If disposing AndAlso Not (components Is Nothing) Then
         components.Dispose()
      End If
      MyBase.Dispose(disposing)
   End Sub

   Friend Class StackRenderer
      Inherits ToolStripProfessionalRenderer
      Private Shared titleBarGripBmp As Bitmap
      Private Shared titleBarGripEnc As String = "Qk16AQAAAAAAADYAAAAoAAAAIwAAAAMAAAABABgAAAAAAAAAAADEDgAAxA4AAAAAAAAAAAAAuGMy+/n5+/n5uGMyuGMy+/n5+/n5uGMyuGMy+/n5+/n5uGMyuGMy+/n5+/n5uGMyuGMy+/n5+/n5uGMyuGMy+/n5+/n5uGMyuGMy+/n5+/n5uGMyuGMy+/n5+/n5uGMyuGMy+/n5+/n5ANj+RzIomHRh+/n5wm8/RzIomHRh+/n5wm8/RzIomHRh+/n5wm8/RzIomHRh+/n5wm8/RzIomHRh+/n5wm8/RzIomHRh+/n5wm8/RzIomHRh+/n5wm8/RzIomHRh+/n5wm8/RzIomHRh+/n5ANj+RzIoRzIozHtMzHtMRzIoRzIozHtMzHtMRzIoRzIozHtMzHtMRzIoRzIozHtMzHtMRzIoRzIozHtMzHtMRzIoRzIozHtMzHtMRzIoRzIozHtMzHtMRzIoRzIozHtMzHtMRzIoRzIozHtMANj+"

      ' Define titlebar colors.
      Private Shared titlebarColor1 As Color = Color.FromArgb(89, 135, 214)
      Private Shared titlebarColor2 As Color = Color.FromArgb(76, 123, 204)
      Private Shared titlebarColor3 As Color = Color.FromArgb(63, 111, 194)
      Private Shared titlebarColor4 As Color = Color.FromArgb(50, 99, 184)
      Private Shared titlebarColor5 As Color = Color.FromArgb(38, 88, 174)
      Private Shared titlebarColor6 As Color = Color.FromArgb(25, 76, 164)
      Private Shared titlebarColor7 As Color = Color.FromArgb(12, 64, 154)
      Private Shared borderColor As Color = Color.FromArgb(0, 0, 128)

      Shared Sub New()
         titleBarGripBmp = StackView.DeserializeFromBase64(titleBarGripEnc)
      End Sub

      Public Sub New()
      End Sub

      Private Sub DrawTitleBar(ByVal g As Graphics, ByVal rect As Rectangle)

         ' Assign the image for the grip.
         Dim titlebarGrip As Image = titleBarGripBmp

         ' Fill the titlebar. 
         ' This produces the gradient and the rounded-corner effect.
         g.DrawLine(New Pen(titlebarColor1), rect.X, rect.Y, rect.X + rect.Width, rect.Y)
         g.DrawLine(New Pen(titlebarColor2), rect.X, rect.Y + 1, rect.X + rect.Width, rect.Y + 1)
         g.DrawLine(New Pen(titlebarColor3), rect.X, rect.Y + 2, rect.X + rect.Width, rect.Y + 2)
         g.DrawLine(New Pen(titlebarColor4), rect.X, rect.Y + 3, rect.X + rect.Width, rect.Y + 3)
         g.DrawLine(New Pen(titlebarColor5), rect.X, rect.Y + 4, rect.X + rect.Width, rect.Y + 4)
         g.DrawLine(New Pen(titlebarColor6), rect.X, rect.Y + 5, rect.X + rect.Width, rect.Y + 5)
         g.DrawLine(New Pen(titlebarColor7), rect.X, rect.Y + 6, rect.X + rect.Width, rect.Y + 6)

         ' Center the titlebar grip.
         g.DrawImage(titlebarGrip, New Point(rect.X + (rect.Width / 2 - titlebarGrip.Width / 2), rect.Y + 1))
      End Sub


      ' This method handles the RenderGrip event.
      Protected Overrides Sub OnRenderGrip(ByVal e As ToolStripGripRenderEventArgs)
         DrawTitleBar(e.Graphics, New Rectangle(0, 0, e.ToolStrip.Width, 7))
      End Sub


      ' This method handles the RenderToolStripBorder event.
      Protected Overrides Sub OnRenderToolStripBorder(ByVal e As ToolStripRenderEventArgs)
         DrawTitleBar(e.Graphics, New Rectangle(0, 0, e.ToolStrip.Width, 7))
      End Sub


      ' This method handles the RenderButtonBackground event.
      Protected Overrides Sub OnRenderButtonBackground(ByVal e As ToolStripItemRenderEventArgs)
         Dim g As Graphics = e.Graphics
         Dim bounds As New Rectangle(Point.Empty, e.Item.Size)

         Dim gradientBegin As Color = Color.FromArgb(203, 225, 252)
         Dim gradientEnd As Color = Color.FromArgb(125, 165, 224)

         Dim button As ToolStripButton = CType(e.Item, ToolStripButton)

         If button.Pressed OrElse button.Checked Then
            gradientBegin = Color.FromArgb(254, 128, 62)
            gradientEnd = Color.FromArgb(255, 223, 154)
         ElseIf button.Selected Then
            gradientBegin = Color.FromArgb(255, 255, 222)
            gradientEnd = Color.FromArgb(255, 203, 136)
         End If

         Dim b = New LinearGradientBrush(bounds, gradientBegin, gradientEnd, LinearGradientMode.Vertical)
         Try
            g.FillRectangle(b, bounds)
         Finally
            b.Dispose()
         End Try

         e.Graphics.DrawRectangle(SystemPens.ControlDarkDark, bounds)

         g.DrawLine(SystemPens.ControlDarkDark, bounds.X, bounds.Y, bounds.Width - 1, bounds.Y)

         g.DrawLine(SystemPens.ControlDarkDark, bounds.X, bounds.Y, bounds.X, bounds.Height - 1)

         Dim toolStrip As ToolStrip = button.Owner
         Dim nextItem As ToolStripButton = CType(button.Owner.GetItemAt(button.Bounds.X, button.Bounds.Bottom + 1), ToolStripButton)

         If nextItem Is Nothing Then
            g.DrawLine(SystemPens.ControlDarkDark, bounds.X, bounds.Height - 1, bounds.X + bounds.Width - 1, bounds.Height - 1)
         End If
      End Sub
   End Class

#Region "Component Designer generated code"


   Private Sub InitializeComponent()
      Me.stackStrip = New System.Windows.Forms.ToolStrip
      Me.mailStackButton = New System.Windows.Forms.ToolStripButton
      Me.calendarStackButton = New System.Windows.Forms.ToolStripButton
      Me.contactsStackButton = New System.Windows.Forms.ToolStripButton
      Me.tasksStackButton = New System.Windows.Forms.ToolStripButton
      Me.stackStrip.SuspendLayout()
      Me.SuspendLayout()
      '
      'stackStrip
      '
      Me.stackStrip.CanOverflow = False
      Me.stackStrip.Dock = System.Windows.Forms.DockStyle.Bottom
      Me.stackStrip.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
      Me.stackStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
      Me.stackStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mailStackButton, Me.calendarStackButton, Me.contactsStackButton, Me.tasksStackButton})
      Me.stackStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
      Me.stackStrip.Location = New System.Drawing.Point(0, 14)
      Me.stackStrip.Name = "stackStrip"
      Me.stackStrip.Padding = New System.Windows.Forms.Padding(0, 7, 0, 0)
      Me.stackStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
      Me.stackStrip.Size = New System.Drawing.Size(261, 136)
      Me.stackStrip.TabIndex = 0
      Me.stackStrip.Text = "toolStrip1"
      '
      'mailStackButton
      '
      Me.mailStackButton.CheckOnClick = True
      Me.mailStackButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
      Me.mailStackButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
      Me.mailStackButton.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
      Me.mailStackButton.Margin = New System.Windows.Forms.Padding(0)
      Me.mailStackButton.Name = "mailStackButton"
      Me.mailStackButton.Padding = New System.Windows.Forms.Padding(3)
      Me.mailStackButton.Size = New System.Drawing.Size(260, 27)
      Me.mailStackButton.Text = " Mail"
      Me.mailStackButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'calendarStackButton
      '
      Me.calendarStackButton.CheckOnClick = True
      Me.calendarStackButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
      Me.calendarStackButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
      Me.calendarStackButton.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
      Me.calendarStackButton.Margin = New System.Windows.Forms.Padding(0)
      Me.calendarStackButton.Name = "calendarStackButton"
      Me.calendarStackButton.Padding = New System.Windows.Forms.Padding(3)
      Me.calendarStackButton.Size = New System.Drawing.Size(260, 27)
      Me.calendarStackButton.Text = " Calendar"
      Me.calendarStackButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'contactsStackButton
      '
      Me.contactsStackButton.CheckOnClick = True
      Me.contactsStackButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
      Me.contactsStackButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
      Me.contactsStackButton.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
      Me.contactsStackButton.Margin = New System.Windows.Forms.Padding(0)
      Me.contactsStackButton.Name = "contactsStackButton"
      Me.contactsStackButton.Padding = New System.Windows.Forms.Padding(3)
      Me.contactsStackButton.Size = New System.Drawing.Size(260, 27)
      Me.contactsStackButton.Text = " Contacts"
      Me.contactsStackButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'tasksStackButton
      '
      Me.tasksStackButton.CheckOnClick = True
      Me.tasksStackButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
      Me.tasksStackButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
      Me.tasksStackButton.ImageTransparentColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
      Me.tasksStackButton.Margin = New System.Windows.Forms.Padding(0)
      Me.tasksStackButton.Name = "tasksStackButton"
      Me.tasksStackButton.Padding = New System.Windows.Forms.Padding(3)
      Me.tasksStackButton.Size = New System.Drawing.Size(260, 27)
      Me.tasksStackButton.Text = " Tasks"
      Me.tasksStackButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
      '
      'StackView
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.Controls.Add(Me.stackStrip)
      Me.Name = "StackView"
      Me.Size = New System.Drawing.Size(261, 150)
      Me.stackStrip.ResumeLayout(False)
      Me.stackStrip.PerformLayout()
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

#End Region
End Class


