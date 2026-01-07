using FirstAdapterExample;

ITarget target = new Adapter(new Adaptee());

target.Request();