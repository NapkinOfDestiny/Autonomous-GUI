from twilio.rest import Client
# put your own credentials here
account_sid = "ACe6e3b5f2354fd0c94aca50e491329750"
auth_token = "f722b2f27b01fc360d3876ec4d92bdcd"
client = Client(account_sid, auth_token)
di = 0

while True:
	di += 1
	client.messages.create(
	  to="5095926723",
	  from_="+1 208-816-7409 ",
	  body="Where Are Canada?",
	  media_url="https://climacons.herokuapp.com/clear.png")

	print(di)
	if di == 100:
		break