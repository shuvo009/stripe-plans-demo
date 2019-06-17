# Stripe Plan Subscription Demo

## Run this demo
1) Singup at Stripe [https://stripe.com](https://stripe.com)
2) Setup your Product and panls [https://stripe.com/docs/billing/subscriptions/examples](https://stripe.com/docs/billing/subscriptions/examples)
3) Copy your Plan Ids at replace it with data-planId at Index.cshtml
4) Get you Publishable key and replace with pk_test_your_stripe_public_key at Index.cshtml [https://dashboard.stripe.com/test/apikeys](https://dashboard.stripe.com/test/apikeys)
5) Download ngrok [https://ngrok.com/](https://ngrok.com/)
6) Run following command at powershell `.\ngrok http -host-header="localhost:59281" 59281`
7) Change Success and Cancel url with ngrok URL at Index.cshtml
8) Add `checkout.session.completed` webhook at Stripe [https://dashboard.stripe.com/test/webhooks](https://dashboard.stripe.com/test/webhooks) 
HookUrl : https://ngrokurl//api/StripeWebHooks/Hook

### you are done thanks
