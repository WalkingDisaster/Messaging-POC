This is a proof of concept demonstrating a few things:
 * Mass Transit with RabbitMQ
 * Peer to Peer messaging
 * Process facilitated by Sagas (persisted using NHibernate)

An explanation of the projects is probably a little necessary:

 * Server - Facilitates the Saga, and does some logging.
 * Contracts - The message contracts, also the Saga and the Fluent NHibernate map for the saga.  This is not the ideal place to put these, but it was practical.
 * Configuration - Shared configuration classes
 * Client1 - Data entry
  * If you want to change a name, enter the old name and the new name.  This will update immediately on Client2
  * If you want to change the income, enter the name under "old name" and the income.  This will go to Client3 for approval.
  * If you want to create a new person, leave old name blank.  The person will show up on Client2 immediately, but the income will not until it is approved on Client3.
 * Client2 - The data.  This isn't persisted.  If you restart, it will reset.
 * Client3 - The approval application
